import { getScript } from './get-script';
import { MapDefinition } from './google-maps/map-definition';
import { registerToGoogleMap as registerJQueryToGoogleMap } from './google-maps/maps-jquery';

const debug = true;
const winAny = window as any;
const globalCallbackName = 'appContentGoogleMapsCallback';

/**
 * Class to load GoogleMaps and activate the jQuery.toGoogleMap(...) function. 
 * When done, it will publish another method which can be called by all parts wanting to register a map using turnOn
 */
export class GoogleMapsTurnOn {

  /** Status to track if activation already started (prevent multiple runs) */
  alreadyActivating = false;

  


  activate(turnOn: any) {
    debugger;
    if(debug) console.log('activate');
    console.log('data', turnOn);
    // var apiKey = turnOn.data;
  
    // Change this GoogleApiKey. They are in the App-Settings. Read instructions here: https://azing.org/2sxc/r/ippFQYkz
    if(!winAny.googleMapsApiKey) return;

    // Prevent multiple inits in case this is triggered again
    if(this.alreadyActivating) return;
    this.alreadyActivating = true;
  
    // This promise will be triggered indirectly when Google Maps has loaded. It's used in the toGoogleMaps
    const loadPromise = $.Deferred();
    registerJQueryToGoogleMap(loadPromise, debug);
  
    // Load Google Maps if not already loading (prevent duplicate inits)
    if (!winAny.googleMapsLoading) {
      winAny.googleMapsLoading = true;
      const keyWithoutWarning = winAny.googleMapsApiKey;
      
      // Callback which google-maps will trigger automatically when loaded
      // we must be sure to not define this twice, as otherwise a second instance would overwrite our version
      const thisInCallback = this;
      if(!winAny[globalCallbackName]) winAny[globalCallbackName] = function() {
        if(debug) console.log('googleMapLoadCallback');
        loadPromise.resolve(true);

        thisInCallback.activateTurnOnMap();
      };

      getScript(`//maps.google.com/maps/api/js?key=${keyWithoutWarning}&sensor=true&callback=${globalCallbackName}`, null);
    }
  

  }

  /** 
   * This is the signature of turnOn once it's initialized. 
   * It doesn't exist at first and will be activated when everything is ready.
   * */
  turnOnMap: (turnOn: any) => void;

  /**
   * Activate the turnOnMap command so this can be used from outside
   */
  private activateTurnOnMap(){
    this.turnOnMap = function(turnOn: any) {
      if(debug) console.log('turn on map', turnOn);
      buildMap(turnOn.data);
    };
  }
}





function buildMap({domId: id, marker, zoom, lat, lng, info, warn } : MapDefinition) {
  console.log('build map', id, marker, arguments);

  ($('#' + id) as any).toGoogleMap({
    position: {
      lat: lat,
      lng: lng
    },
    zoom: zoom,
    mapTypeId: "ROADMAP",
    infoWindowHtml: info,
    showInfoWindow: false,
    icon: marker
  });

  if(warn) showKeyWarnings();
};

function showKeyWarnings() {
  const googleMapsElem = $('.co-google-map-container');

  // check if it's the original key, which shouldn't be used in live sites
  // do not turn this off, it's important!
  // to disable the warning, replace the API key as explained on //github.com/2sic/2sxc-content-bootstrap3/wiki/google-maps-api-key
  if(googleMapsElem.length != 0)
    googleMapsElem.each(function(i, elem) {
      if (!$(elem).hasClass('has-warning')) {
        $(elem).addClass('has-warning');
        $(elem).append('<p class="alert alert-danger googlemap-apiwarning"><strong>Warning:</strong> This map uses a demo API-Key, which will cause problems on live web sites. Change the GoogleApiKey using <a class="alert-link target="_blank" href="https://azing.org/2sxc/r/ippFQYkz" target="_blank">these instructions</a></p>');
      }
    });
}