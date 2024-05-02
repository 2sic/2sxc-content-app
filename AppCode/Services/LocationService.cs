using AppCode.Data;

namespace AppCode.Services
{
  /// <summary>
  /// Simple service to encrypt eMail addresses in the resulting HTML.
  /// To use, must be created using GetService<LocationService>() in your view, as it needs the Kit.
  /// </summary>
  public class LocationService: Custom.Hybrid.CodeTyped
  {
    public string RoutingUrl(Location loc)
    {
      // Language is used for the map-link
      // var content = AsItem(dynContent as object);
      var language = MyContext.Culture.CurrentCode.Split(new[] { '-' })[0];

      var gps = loc.GpsCoordinates;
      // this link will be used to open the Google-Directions in a new window
      return gps.Longitude > 0
        // if we have coordinates, use them
        ? "https://www.google.com/maps/dir/" + Kit.Convert.ForCode(gps.Latitude) + "," + Kit.Convert.ForCode(gps.Longitude)
        // otherwise use the address
        : "https://maps.google.com/maps?daddr="
          + $"{loc.Street} {loc.ZipCode} {loc.City} {loc.Country}".Replace(" ", "+")
          + "&amp;saddr=&amp;f=d&amp;hl=" + language + "&amp;ie=UTF8&amp;z=16";
    }

  }
}