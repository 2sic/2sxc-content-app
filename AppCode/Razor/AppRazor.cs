using AppCode.Data;
using ToSic.Sxc.Apps;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract partial class AppRazor: Custom.Hybrid.RazorTyped
  {
    /// <summary>
    /// Typed App with typed Settings & Resources
    /// </summary>
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>();
    private IAppTyped<AppSettings, AppResources> _app;
    
    /// <summary>
    /// Special helpers for titles, toolbars etc.
    /// </summary>
    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;
  }
}