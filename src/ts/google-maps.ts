
declare const google : any;

/* Google Maps API Key */
export function activateGoogleMaps() {
  
  const winAny = window as any;
  // Change this GoogleApiKey. They are in the App-Settings. Read instructions here: https://azing.org/2sxc/r/ippFQYkz
  let googleApiKey = winAny.googleMapsApiKey;
  if(!googleApiKey) return; 

  const googleMapsElem = $('.co-google-map-container');

  const showApiKeyWarning = googleApiKey.indexOf("warning!") > -1;
  googleApiKey = googleApiKey.replace("warning!", "");

  // the init-code
  function initGoogleMaps(elem: HTMLElement) {
    // if this had already been run, stop here
    if (($.fn as any).toGoogleMap) {
        return;
    }

    console.log('initGoogleMaps');

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
        googleMapLoadDeferred.resolve(true);
    };

    if (!winAny.googleMapsLoaded) {
      winAny.googleMapsLoaded = true;
        getScript("//maps.google.com/maps/api/js?key=" + googleApiKey + "&sensor=true&callback=googleMapLoadCallback");
    }
  }

  function getScript(source: string) {
    var script = document.createElement('script');
    var prior = document.getElementsByTagName('script')[0];
    (script as any).async = 1;

    (script as any).onload = (script as any).onreadystatechange = function( _: any, isAbort: any ) {
        if(isAbort || !(script as any).readyState || /loaded|complete/.test((script as any).readyState) ) {
            script.onload = (script as any).onreadystatechange = null;
            script = undefined;
        }
    };

    script.src = source;
    prior.parentNode.insertBefore(script, prior);
}


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

      initGoogleMaps(this);
    })
  }
}
