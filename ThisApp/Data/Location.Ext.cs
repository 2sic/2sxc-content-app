using ToSic.Sxc.Context;

namespace ThisApp.Data
{
  public partial class Location
  {
    public GpsCoordinates GpsCoordinates => _gpsCoordinates ?? (_gpsCoordinates = ParseGps(Gps));
    private GpsCoordinates _gpsCoordinates;

    private GpsCoordinates ParseGps(string gpsJson)
    {
      // GPS is a JSON field, so we must use the Json.ToTyped to access the properties
      var coords = Kit.Json.ToTyped(gpsJson, propsRequired: false);
      return new GpsCoordinates {
        Latitude = coords.Double("Latitude"),
        Longitude = coords.Double("Longitude")
      };
    }

    public string RoutingUrl(ICmsContext context)
    {
      // Language is used for the map-link
      // var content = AsItem(dynContent as object);
      var language = context.Culture.CurrentCode.Split(new[] { '-' })[0];

      var gps = GpsCoordinates;
      // this link will be used to open the Google-Directions in a new window
      return gps.Longitude > 0
        // if we have coordinates, use them
        ? "https://www.google.com/maps/dir/" + Kit.Convert.ForCode(gps.Latitude) + "," + Kit.Convert.ForCode(gps.Longitude)
        // otherwise use the address
        : "https://maps.google.com/maps?daddr="
          + (Street + " " + ZipCode + " " + City + " " + Country).Replace(" ", "+")
          + "&amp;saddr=&amp;f=d&amp;hl=" + language + "&amp;ie=UTF8&amp;z=16";
    }

  }

  public class GpsCoordinates
  {
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }

}