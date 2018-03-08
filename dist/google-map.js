(function ($) {
    // Change this GoogleApiKey. Get it on Google API Console (https://console.developers.google.com/apis/)
    // read instructions here: https://github.com/2sic/2sxc-content-app/wiki/google-maps-api-key
    var googleApiKey = "AIzaSyAUbRHtu3k_fg3jDGk_qAatE5jA4bC_ndE";


    // the init-code
    function initGoogleMaps() {

        // if this had already been run, stop here
        if ($.fn.toGoogleMap)
            return;

        var googleMapLoadDeferred = $.Deferred();

        $.fn.toGoogleMap = function (options) {
            var mapElement = this.get(0);

            googleMapLoadDeferred.promise().then(function() {
                
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
                    map: map
                });

                if(settings.infoWindowHtml && settings.infoWindowHtml !== '') {
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
        window.googleMapLoadCallback = function() {
            googleMapLoadDeferred.resolve(true);
        };
        
        if(!window.googleMapsLoaded)
        {
            window.googleMapsLoaded = true;
            $.getScript("//maps.google.com/maps/api/js?key=" + googleApiKey + "&sensor=true&callback=googleMapLoadCallback");
        }
    }


    // check if it's the original key, which shouldn't be used in live sites
    // do not turn this off, it's important!
    // to disable the warning, replace the API key as explained on //github.com/2sic/2sxc-content-bootstrap3/wiki/google-maps-api-key
    function showWarningIfDemoKeyIsUsed() {
        var showApiKeyWarning = googleApiKey === "A-I-z-a-S-yAUbRHtu3k_fg3jDGk_qAatE5jA4bC_ndE".replace(/-/g, "");
        if(showApiKeyWarning){
            $('.co-google-map-container').append('<p class="alert alert-danger googlemap-apiwarning"><strong>Warning:</strong> This map uses a demo API-Key, which will cause problems on live web sites. Change the GoogleApiKey using <a class="alert-link target="_blank" href="https://github.com/2sic/2sxc-content-bootstrap3/wiki/google-maps-api-key" target="_blank">these instructions</a></p>');
        }
    }

    $(showWarningIfDemoKeyIsUsed);

    initGoogleMaps();

} (jQuery));