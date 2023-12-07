using ToSic.Sxc.Data;

public class LocationHelper: Custom.Hybrid.CodeTyped
{
  // check a link, prepare target window, icon etc. based on various settings
  public object MapInfos(ITypedItem content) {

    // Language is used for the map-link
    // var content = AsItem(dynContent as object);
    var language = MyContext.Culture.CurrentCode.Split(new[] { '-' })[0];

    // GPS is a JSON field, so we must use AsDynamic to access the properties
    var gps = Kit.Json.ToTyped(content.String("GPS"));
    var gpsLong = gps.Double("Longitude", fallback: 0);
    var gpsLat = gps.Double("Latitude", fallback: 0);

    // this link will be used to open the Google-Directions in a new window
    var directionurl = gpsLong > 0
      // if we have coordinates, use them
      ? "https://www.google.com/maps/dir/" + Kit.Convert.ForCode(gpsLat) + "," + Kit.Convert.ForCode(gpsLong)
      // otherwise use the address
      : "https://maps.google.com/maps?daddr="
        + (content.Get("Street") + " " + content.Get("ZipCode") + " " + content.Get("City") + " " + content.Get("Country"))
          .Replace(" ", "+")
        + "&amp;saddr=&amp;f=d&amp;hl=" + language + "&amp;ie=UTF8&amp;z=16";

    return new {
      GpsLong = gpsLong,
      GpsLat = gpsLat,
      DirectionUrl = directionurl,
    };
  }
  
}