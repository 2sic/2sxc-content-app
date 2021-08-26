import { getScript } from '../get-script';
import { MapDefinition } from './map-definition';
import { registerToGoogleMap as registerJQueryToGoogleMap } from './maps-jquery';

const debug = false;
const winAny = window as any;
const globalCallbackName = 'appContentGoogleMapsCallback';

/**
 * Class to load GoogleMaps and activate the jQuery.toGoogleMap(...) function. 
 * When done, it will publish another method which can be called by all parts wanting to register a map using turnOn
 */
export class GoogleMapsTurnOn {

  /** 
   * This is the signature of turnOn once it's initialized. 
   * It doesn't exist at first and will be provided when everything is ready.
   */
  configureMap: (data: MapDefinition) => void;

  /** Status to track if loading already started (prevent multiple runs) */
  isLoading = false;

  /** Load Google Maps and prepare for use */
  load(apiKey: string) {
    if(debug) console.log('activate', apiKey);
    if(!apiKey) return;           // check api key exists
    if(this.isLoading) return;    // Prevent multiple inits in case this is triggered again
    this.isLoading = true;
  
    // This promise will be triggered indirectly when Google Maps has loaded. It's used in the toGoogleMaps
    const loadPromise = $.Deferred();
    registerJQueryToGoogleMap(loadPromise, debug);
        
    // Callback which google-maps will trigger automatically when loaded
    // we must be sure to not define this twice, as otherwise a second instance would overwrite an initialized one
    const thisInCallback = this;
    if(!winAny[globalCallbackName]) winAny[globalCallbackName] = function() {
      if(debug) console.log('googleMapLoadCallback');

      // Resolve promise so the jQuery toGoogleMap can start working
      loadPromise.resolve(true);
      
      // Now Activate the turnOnMap command so this can be used from outside
      thisInCallback.configureMap = configureMap; 
    };

    // Load the Google Maps scripts - will trigger the callback (see above)
    getScript(`//maps.google.com/maps/api/js?key=${apiKey}&sensor=true&callback=${globalCallbackName}`, null);
  }
}



function configureMap({domId, icon, zoom, lat, lng, info, warn } : MapDefinition) {
  if(debug) console.log('build map', arguments);

  (window as any).toGoogleMap(document.getElementById(domId), {
    position: {
      lat: lat,
      lng: lng
    },
    zoom: zoom,
    mapTypeId: "ROADMAP",
    infoWindowHtml: info,
    showInfoWindow: false,
    icon: icon
  });

  if(warn) showKeyWarnings();
};

function showKeyWarnings() {
  // check if it's the original key, which shouldn't be used in live sites
  // do not turn this off, it's important!
  // to disable the warning, replace the API key as explained on //github.com/2sic/2sxc-content-bootstrap3/wiki/google-maps-api-key
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