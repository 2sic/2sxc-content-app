using AppCode.Data;
using ToSic.Sxc.Apps;

/// <summary>
/// WIP Autogenerating
/// </summary>
namespace AppCode.Razor
{
  public abstract partial class AppRazor: AppRazor<object>
  {

  }

  /// <summary>
  /// todo
  /// </summary>
  public abstract partial class AppRazor<TModel>: Custom.Hybrid.RazorTyped<TModel>
  {
    /// <summary>
    /// Typed App with typed Settings & Resources
    /// </summary>
    public new IAppTyped<AppSettings, AppResources> App => _app ??= Customize.App<AppSettings, AppResources>();
    private IAppTyped<AppSettings, AppResources> _app;
    
  }
}