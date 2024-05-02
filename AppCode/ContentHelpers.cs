using System.Collections.Generic;
using System.Linq;
using AppCode.Data;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;
using ToSic.Sxc.Edit.Toolbar;

namespace AppCode
{
  public class ContentHelpers: Custom.Hybrid.CodeTyped
  {

    /// <summary>
    /// Create a special toolbar with the option to hide image and/or text.
    /// This works, because the content-type "Content" has formulas which expect these parameters.
    /// </summary>
    /// <param name="item"></param>
    /// <param name="hideImage">tell the formula in the edit-UI to hide the image field</param>
    /// <param name="hideText">tell the formula in the edit-UI to hide the long text field</param>
    /// <returns></returns>
    public IToolbarBuilder TextImageToolbar(TextImage item, bool hideImage, bool hideText = false)
      => Kit.Toolbar.Default(item, tweak: b => b.FormParameters(new
      {
        hideImage,
        hideText
      }));
   

    /// <summary>
    /// Create a dynamic title tag using different tags such as <h1>, <h2> etc.
    /// based on the requested size or the presentation settings
    /// </summary>
    /// <returns></returns>
    public IHtmlTag ShowTitle(ITypedItem item)
    {
      var tag = Kit.Convert.As<TextMediaPresentation>(item.Presentation).HeadingType;
      if (tag is null || tag == "" || tag == "hide") return null;

      return Kit.HtmlTags.Custom(tag, item.Title);
    }


    /// <summary>
    /// Process a list and return an object with more information.
    /// For example, how to style the last Row etc.
    /// </summary>
    /// <param name="items"></param>
    /// <param name="alternate"></param>
    /// <param name="startWithText"></param>
    /// <returns></returns>
    public List<T> PrepareList<T>(IEnumerable<T> items, bool alternate = false, bool startWithText = true) where T : IAlternatingItems
    => items.Select((item, index) =>
      {
        item.TextIsFirst = IsCurrentTextFirst(index, alternate, startWithText);
        item.IsLast = index == items.Count() - 1;
        return item;
      }).ToList();

    /// <summary>
    /// Detect if the text should be placed first or last, based on the index and settings.
    /// </summary>
    private static bool IsCurrentTextFirst(int index, bool alternate, bool initialTextFirst)
    {
      // If we don't alternate, then the text is always placed same as initial text
      if (!alternate) return initialTextFirst;

      // If we alternate, then flip every even item
      return initialTextFirst ^ (index % 2) == 0;
    }

  }
}