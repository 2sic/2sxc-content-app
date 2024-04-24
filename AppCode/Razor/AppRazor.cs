using AppCode.Data;
using ToSic.Sxc.Apps;

/// <summary>
/// WIP Autogenerating
/// </summary>
namespace AppCode.Razor
{
  public abstract partial class AppRazor
  {

  }

  /// <summary>
  /// Base class for all Razor templates in this app
  /// </summary>
  public abstract partial class AppRazor<TModel>
  {
    /// <summary>
    /// Special helpers for titles, toolbars etc.
    /// </summary>
    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;

    protected string ActivateFancyBox(string id)
    {
      // Init options for fancybox binding
      // This is only partial - if you want to see more, see https://fancyapps.com/docs/ui/fancybox/options
      var fancyboxOptions = new {
        groupAll = true,
        mainClass = "app-content-fancybox", 
        Thumbs = new {
          autoStart = false
        }
      };

      var data = new {
        attribute = id,
        options = fancyboxOptions
      };

      // see https://r.2sxc.org/turnon
      Kit.Page.Activate("fancybox4");

      // When the page is ready, run initFancybox JS 
      Kit.Page.TurnOn("window.appContent.initFancybox()", data: data, require: "window.Fancybox");

      return null;
    }
  }
}