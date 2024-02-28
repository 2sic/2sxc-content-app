using AppCode.Data;
using ToSic.Sxc.Apps;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class AppRazor: Custom.Hybrid.RazorTyped
  {
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>(); // GetService<IAppTyped<AppSettings, AppResources>>();
    private IAppTyped<AppSettings, AppResources> _app;
    
    // /// <summary>
    // /// The App Resources as a strongly typed object
    // /// </summary>
    // protected AppResources AppResources => _appResources ??= As<AppResources>(App.Resources);
    // private AppResources _appResources;

    // /// <summary>
    // /// The App Settings as a strongly typed object
    // /// </summary>
    // protected AppSettings AppSettings => _appSettings ??= As<AppSettings>(App.Settings);
    // private AppSettings _appSettings;

    /// <summary>
    /// Special helpers for titles, toolbars etc.
    /// </summary>
    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;
  }
}