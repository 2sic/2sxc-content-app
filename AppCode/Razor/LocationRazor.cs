using AppCode.Data;
using ToSic.Razor.Blade;

namespace AppCode.Razor
{
  /// <summary>
  /// Base class for Location Razor templates
  /// </summary>
  public abstract class LocationRazor: AppRazor
  {
    protected Location MyLocation => _loc ??= As<Location>(MyItem);
    private Location _loc;

    /// <summary>
    /// defines a unique dom Id for google map
    /// </summary>
    protected string GoogleMapsDomId => "app-content-google-map-js-" + UniqueKey;

    /// <summary>
    /// They Google API key is in the App-Settings. See instructions: https://azing.org/2sxc/r/ApSwlItl
    /// The Preset-data is encrypted, so we must decrypt it to use
    /// </summary>
    protected object MapsApiKey => Kit.SecureData.Parse(AllSettings.String("GoogleMaps.ApiKey")).Value;

    /// <summary>
    /// Instruct turnOn to activate GoogleMaps with the API key and everything once everything is loaded - uses turnOn https://r.2sxc.org/turnon
    /// </summary>
    protected string ActivateMap() => Kit.Page.TurnOn("window.appContent.activeGoogleMaps()", data: new
    {
      apiKey = MapsApiKey,
      domId = GoogleMapsDomId,
      icon = AllSettings.String("GoogleMaps.MarkerIcon") ?? "",
      lat = MyLocation.GpsCoordinates.Latitude,
      lng = MyLocation.GpsCoordinates.Longitude,
      zoom = AllSettings.Int("GoogleMaps.Zoom"),
      info = MyLocation.Company,
    });

    protected IHtmlTag ShowWarningIfKeyMissing()
    {
      // Decrypt the Api key
      var apiKey = Kit.SecureData.Parse(AllSettings.String("GoogleMaps.ApiKey")); 
  
      // If the key is not from preset, then we don't need to show the warning (return)
      if (!apiKey.IsSecuredBy("preset")) return null;

      return Kit.HtmlTags.Div().Class("alert alert-danger position-absolute bottom-0 start-0").Wrap(
        AllResources.String("GoogleMaps.WarningApiKeyForDemoOnly")
      );
    }
  }
}