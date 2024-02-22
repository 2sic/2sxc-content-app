using ToSic.Sxc.Context;

namespace AppCode.Data
{
  // TODO: @2dm - review use of context and Kit!
  public partial class Location
  {
    public string RoutingUrl(ICmsContext context)
    {
      // Language is used for the map-link
      // var content = AsItem(dynContent as object);
      var language = context.Culture.CurrentCode.Split(new[] { '-' })[0];

      var gps = GPS;
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
}