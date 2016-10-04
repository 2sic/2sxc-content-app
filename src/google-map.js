(function ($) {
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
                draggable: false,
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
        $.getScript("http://maps.google.com/maps/api/js?key=AIzaSyBpZ-EbQw7h16uEiEWQT4Kbm10q7uvPG00&sensor=true&callback=googleMapLoadCallback");
    }

} (jQuery));