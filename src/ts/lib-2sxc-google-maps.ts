import { setOptions, importLibrary } from '@googlemaps/js-api-loader';
import { GoogleMapsOptions } from './lib-2sxc-google-maps-options';

const debug = false;

export async function activeGoogleMaps({apiKey, domId, icon, zoom, lat, lng, info } : GoogleMapsOptions) {
  if(debug) console.log('build map', arguments);

  setOptions({
    key: apiKey,
    v: "weekly",
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

  const { Map } = await importLibrary('maps');
  const { AdvancedMarkerElement } = await importLibrary('marker');

  const map = new Map(document.getElementById(domId), mapOptions);

  const markerContent = icon ? Object.assign(document.createElement('img'), { src: icon }) : undefined;

  const marker = new AdvancedMarkerElement({
    position: {
      lat: lat,
      lng: lng
    },
    map: map,
    ...(markerContent && { content: markerContent })
  });

  if (info && info !== '') {
    const { InfoWindow } = await importLibrary('maps');
    const infoWindow = new InfoWindow({ content: info });
    marker.addListener('gmp-click', () => {
      infoWindow.open({ anchor: marker, map });
    });
  }

  if(debug) console.log('map loaded');
}