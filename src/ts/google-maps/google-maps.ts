import { Loader } from '@googlemaps/js-api-loader';
import { MapDefinition } from './map-definition';

const debug = false;

export function activeGoogleMaps({apiKey, domId, icon, zoom, lat, lng, info, warn } : MapDefinition) {
  if(debug) console.log('build map', arguments);

  const loader = new Loader({
    apiKey: apiKey,
    version: "weekly",
    libraries: ["places"]
  });

  const mapOptions = {
    center: {
      lat: lat,
      lng: lng
    },
    zoom: zoom,
    mapTypeControl: true,
    zoomControl: true,
    scaleControl: true,
    scrollwheel: false,
    mapTypeId: 'roadmap'
  };

  if(warn) showKeyWarnings();

  loader.load().then((google) => {
    var map = new google.maps.Map(document.getElementById(`${domId}`), mapOptions);

    var marker = new google.maps.Marker({
      position: {
        lat: lat,
        lng: lng
      },
      map: map,
      icon: icon
    });

    if (info && info !== '') {
      // Create InfoWindow
      var infoWindow = new google.maps.InfoWindow({
          content: info
      });

      // Add Event listener
      google.maps.event.addListener(marker, 'click', function () {
          infoWindow.open(map, marker);
      });
    }

    if(debug) console.log('map loaded');
  });

  function showKeyWarnings() {
    var googleMapsElem = document.getElementsByClassName('co-google-map-container');

    if(googleMapsElem.length != 0) {
      for(var i = 0; i < googleMapsElem.length; i++) {
        if(!googleMapsElem[i].classList.contains('has-warning')) {
          googleMapsElem[i].classList.add('has-warning');
          googleMapsElem[i].innerHTML = googleMapsElem[i].innerHTML + '<p class="alert alert-danger googlemap-apiwarning"><strong>Warning:</strong> This map uses a demo API-Key, which will cause problems on live web sites. Change the GoogleApiKey using <a class="alert-link target="_blank" href="https://azing.org/2sxc/r/ippFQYkz" target="_blank">these instructions</a></p>';
        }
      }
    }
  }
}