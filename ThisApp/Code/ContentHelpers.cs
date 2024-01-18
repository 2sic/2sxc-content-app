using System.Collections.Generic;
using System.Linq;
using ThisApp.Data;
using ToSic.Sxc.Data;
using ToSic.Sxc.Edit.Toolbar;
using ToSic.Sxc.Services;

namespace ThisApp.Code
{
  public static class ContentHelpers
  {
    /// <summary>
    /// Create a special toolbar with the option to hide image and/or text.
    /// This works, because the content-type "Content" has formulas which expect these parameters.
    /// </summary>
    /// <param name="kit"></param>
    /// <param name="item"></param>
    /// <param name="hideImage"></param>
    /// <param name="hideText"></param>
    /// <returns></returns>
    public static IToolbarBuilder Toolbar(ServiceKit16 kit, ITypedItem item, bool hideImage = true, bool hideText = false)
      => kit.Toolbar.Default(item, tweak: b => b.FormParameters(new
      {
        hideImage,
        hideText
      }));

    public static List<ContentExtended> Prepare(IEnumerable<ITypedItem> items, TextMediaViewSettings settings, ContentListHeader headerSettings)
      => PrepareList(items, headerSettings.AlternatePositions, settings.TextFirst);

    /// <summary>
    /// Process a list and return an object with more information.
    /// For example, how to style the last Row etc.
    /// </summary>
    /// <param name="items"></param>
    /// <param name="alternate"></param>
    /// <param name="startWithText"></param>
    /// <returns></returns>
    public static List<ContentExtended> PrepareList(IEnumerable<ITypedItem> items, bool alternate = false, bool startWithText = true)
      => items.Select((item, index) => new ContentExtended(
            item,
            textIsFirst: IsCurrentTextFirst(index, alternate, startWithText),
            isLast: index == items.Count() - 1
          ))
        .ToList();

    /// <summary>
    /// Detect if the text should be placed first or last, based on the index and settings.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="alternate"></param>
    /// <param name="initialTextFirst"></param>
    /// <returns></returns>
    public static bool IsCurrentTextFirst(int index, bool alternate, bool initialTextFirst)
    {
      // If we don't alternate, then the text is always placed same as initial text
      if (!alternate) return initialTextFirst;

      // If we alternate, then flip every even item
      return initialTextFirst ^ (index % 2) == 0;
    }

  }
}