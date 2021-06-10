import { getScript } from './get-script';
import { MapDefinition } from './google-maps/map-definition';
import { registerToGoogleMap } from './google-maps/maps-jquery';

const debug = true;
const winAny = window as any;
// let readyToProcessQueue = false;

// This will be completed once google maps loaded - for listener to wait for
const googleMapLoadDeferred = $.Deferred();

let alreadyActivating = false;

/* Boot Google Maps with the API Key */
export function activateGoogleMaps(objToExpandWhenDone: any) {
  
  // Change this GoogleApiKey. They are in the App-Settings. Read instructions here: https://azing.org/2sxc/r/ippFQYkz
  if(!winAny.googleMapsApiKey) return;
  if(alreadyActivating) return;
  alreadyActivating = true;

  registerToGoogleMap(googleMapLoadDeferred, debug);

  // Load Google Maps if not already loading (prevent duplicate inits)
  if (!winAny.googleMapsLoading) {
    winAny.googleMapsLoading = true;
    const keyWithoutWarning = winAny.googleMapsApiKey.replace("warning!", "");
    getScript("//maps.google.com/maps/api/js?key=" + keyWithoutWarning + "&sensor=true&callback=googleMapLoadCallback", null);
  }

  googleMapLoadDeferred.then(function() {
    if(debug) console.log('maps loaded - will attach turnOnMap');
    objToExpandWhenDone.turnOnMap = turnOnMap;
  });
}


// Callback which google-maps will trigger automatically when loaded
winAny.googleMapLoadCallback = function() {
  if(debug) console.log('googleMapLoadCallback');
  googleMapLoadDeferred.state
  googleMapLoadDeferred
    .resolve(true)
    // process the queue after init, in case something is waiting
    // .then(() => {
    //   readyToProcessQueue = true;
    //   processQueue();
    // })
    ;
}

function turnOnMap(turnOn: any) {
  if(debug) console.log('turn on map', turnOn);
  buildMap(turnOn.data);
}

// TODO: SET ID to be the full id
function buildMap({id, marker, zoom, lat, lng, info} : MapDefinition) {
  console.log('build map', id, marker, arguments);

  ($("#GoogleMap-" + id) as any).toGoogleMap({
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

  showKeyWarnings();
};

// /**
//  * Process the queue on window.appContent.mapQueue if there is something to process
//  */
// export function processQueue() {
//   if(!readyToProcessQueue) return;
//   var mapQueue = winAny?.appContent?.mapQueue as Function[];
//   if(mapQueue?.length) {
//     mapQueue.forEach(fn => {
//       fn();
//     });
//     showKeyWarnings();
//     // reset queue
//     winAny.appContent.mapQueue = new Array<Function>();
//   }
// }



function showKeyWarnings() {
  const showApiKeyWarning = winAny.googleMapsApiKey.indexOf("warning!") > -1;
  if(!showApiKeyWarning) return;

  const googleMapsElem = $('.co-google-map-container');

  // check if it's the original key, which shouldn't be used in live sites
  // do not turn this off, it's important!
  // to disable the warning, replace the API key as explained on //github.com/2sic/2sxc-content-bootstrap3/wiki/google-maps-api-key
  function showWarningIfDemoKeyIsUsed(elem: HTMLElement) {
    if (showApiKeyWarning && !$(elem).hasClass('has-warning')) {
      $(elem).addClass('has-warning');
      $(elem).append('<p class="alert alert-danger googlemap-apiwarning"><strong>Warning:</strong> This map uses a demo API-Key, which will cause problems on live web sites. Change the GoogleApiKey using <a class="alert-link target="_blank" href="https://azing.org/2sxc/r/ippFQYkz" target="_blank">these instructions</a></p>');
    }
  }

  if(googleMapsElem.length != 0)
    googleMapsElem.each(function() {
      showWarningIfDemoKeyIsUsed(this);
    });
}