// This will be attached to window once google is loaded
declare const google : any;

// the init-code
export function registerToGoogleMap(mapsLoadedPromise: JQuery.Deferred<any, any, any>, debug: boolean) {
  if(debug) console.log('giveJqueryMaps-before');

  // if this had already been run, stop here
  // if (($.fn as any).toGoogleMap) return;

  if(debug) console.log('giveJqueryGoogleMaps-after check');


  (window as any).toGoogleMap = function (mapElem: HTMLElement, options: any) {
    var mapElement = mapElem;

    mapsLoadedPromise.promise().then(function () {

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

    return mapElem;
  };

  if(debug) console.log('giveJqueryGoogleMaps-after');
}