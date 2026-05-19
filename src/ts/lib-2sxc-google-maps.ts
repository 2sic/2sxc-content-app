import { Loader } from '@googlemaps/js-api-loader';
import { GoogleMapsOptions } from './lib-2sxc-google-maps-options';

const debug = false;

export function activeGoogleMaps({apiKey, domId, icon, zoom, lat, lng, info } : GoogleMapsOptions) {
  if(debug) console.log('build map', arguments);

  const loader = new Loader({
    apiKey: apiKey,
    version: "weekly",
    libraries: ["places", "marker"]
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
    mapTypeId: 'roadmap',
    mapId: domId
  };

  loader.load().then((google) => {
    var map = new google.maps.Map(document.getElementById(domId), mapOptions);

    const markerContent = icon ? Object.assign(document.createElement('img'), { src: icon }) : undefined;

    var marker = new google.maps.marker.AdvancedMarkerElement({
      position: {
        lat: lat,
        lng: lng
      },
      map: map,
      ...(markerContent && { content: markerContent })
    });

    if (info && info !== '') {
      // Create InfoWindow
      var infoWindow = new google.maps.InfoWindow({
          content: info
      });

      // Add Event listener
      marker.addListener('gmp-click', function () {
          infoWindow.open({ anchor: marker, map });
      });
    }

    if(debug) console.log('map loaded');
  });
}