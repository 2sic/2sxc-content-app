using ThisApp.Data;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;
using ToSic.Sxc.Services;

namespace ThisApp
{
  public static class TitleMaker
  {
    /// <summary>
    /// Create a dynamic title tag using different tags such as <h1>, <h2> etc.
    /// based on the requested size or the presentation settings
    /// </summary>
    /// <param name="kit"></param>
    /// <param name="item"></param>
    /// <param name="tag"></param>
    /// <returns></returns>
    public static IHtmlTag Title(ServiceKit16 kit, ITypedItem item, string tag = null)
    {
      tag ??= new PresSetText(item.Presentation).HeadingType;
      if (tag is null || tag == "" || tag == "hide") return null;

      return kit.HtmlTags.Custom(tag, item.Title);
    }

  }
}