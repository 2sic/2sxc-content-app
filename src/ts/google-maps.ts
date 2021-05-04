import { getScript } from './get-script';

const debug = true;

declare const google : any;

const winAny = window as any;

let readyToProcessQueue = false;

/**
 * Process the queue on window.appContent.mapQueue if there is something to process
 */
export function processQueue() {
  if(!readyToProcessQueue) return;
  var mapQueue = winAny?.appContent?.mapQueue as Function[];
  if(mapQueue?.length) {
    mapQueue.forEach(fn => {
      fn();
    });
    showKeyWarnings();
    // reset queue
    winAny.appContent.mapQueue = new Array<Function>();
  }
}

// the init-code
export function giveJqueryGoogleMaps() {
  if(debug) console.log('giveJqueryMaps-before');
  // if this had already been run, stop here
  if (($.fn as any).toGoogleMap) {
    return;
  }

  if(debug) console.log('giveJqueryGoogleMaps-after check');

  var googleMapLoadDeferred = $.Deferred();

  ($.fn as any).toGoogleMap = function (options: any) {
      var mapElement = this.get(0);

      googleMapLoadDeferred.promise().then(function () {

          var settings = $.extend({
              position: {
                  lat: 0,
                  lng: 0
              },
              zoom: 8,
              mapTypeId: "HYBRID",
              infoWindowHtml: "",
              showInfoWindow: true
          }, options);

          var mapOptions = {
              zoom: settings.zoom,
              mapTypeControl: true,
              center: settings.position,
              zoomControl: true,
              scaleControl: true,
              scrollwheel: false,
              mapTypeId: google.maps.MapTypeId[settings.mapTypeId]
          };

          var map = new google.maps.Map(mapElement, mapOptions);

          // Create Marker
          var marker = new google.maps.Marker({
              position: settings.position,
              map: map,
              icon: settings.icon
          });

          if (settings.infoWindowHtml && settings.infoWindowHtml !== '') {
              // Create InfoWindow
              var infoWindow = new google.maps.InfoWindow({
                  content: settings.infoWindowHtml
              });
              // Add Event listener
              google.maps.event.addListener(marker, 'click', function () {
                  infoWindow.open(map, marker);
              });
          }

          google.maps.event.addListenerOnce(map, 'idle', function () {
              if (settings.showInfoWindow)
                  infoWindow.open(map, marker);
          });

      });

      return this;
  };

  // Register google map load callback
  winAny.googleMapLoadCallback = function () {
    if(debug) console.log('googleMapLoadCallback');
    googleMapLoadDeferred
      .resolve(true)
      // process the queue after init, in case something is waiting
      .then(() => {
        readyToProcessQueue = true;
        processQueue();
      });
  };

  if(debug) console.log('giveJqueryGoogleMaps-after');


  if (!winAny.googleMapsLoading) {
    winAny.googleMapsLoading = true;
    getScript("//maps.google.com/maps/api/js?key=" + winAny.googleMapsApiKey + "&sensor=true&callback=googleMapLoadCallback", winAny.googleMapLoadCallback);
  }
}




let showApiKeyWarning = false;

/* Google Maps API Key */
export function activateGoogleMaps() {
  
  // Change this GoogleApiKey. They are in the App-Settings. Read instructions here: https://azing.org/2sxc/r/ippFQYkz
  if(!winAny.googleMapsApiKey) return; 

  showApiKeyWarning = winAny.googleMapsApiKey.indexOf("warning!") > -1;

  // const googleMapsElem = $('.co-google-map-container');
  winAny.googleMapsApiKey = winAny.googleMapsApiKey.replace("warning!", "");

  giveJqueryGoogleMaps();
}

function showKeyWarnings() {
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

  if(googleMapsElem.length != 0) {
    googleMapsElem.each(function() {
      showWarningIfDemoKeyIsUsed(this);
    })
  }
}