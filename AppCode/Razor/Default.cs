using AppCode.Data;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class Default: Custom.Hybrid.RazorTyped
  {
    /// <summary>
    /// The App Resources as a strongly typed object
    /// </summary>
    protected AppResources AppResources => _appResources ??= As<AppResources>(App.Resources);
    private AppResources _appResources;

    /// <summary>
    /// The App Settings as a strongly typed object
    /// </summary>
    protected AppSettings AppSettings => _appSettings ??= As<AppSettings>(App.Settings);
    private AppSettings _appSettings;

    /// <summary>
    /// Special helpers for titles, toolbars etc.
    /// </summary>
    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;
  }
}