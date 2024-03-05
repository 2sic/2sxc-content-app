using System.Collections.Generic;
using AppCode.Data;
using Custom.Data;
using ToSic.Sxc.Context;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class TextMediaRazor: AppRazor
  {
    /// <summary>
    /// Replace the MyView with a typed version
    /// </summary>
    protected new ICmsView<TextMediaViewSettings, CustomItem> MyView => Customize.MyView<TextMediaViewSettings, CustomItem>();

    protected List<TextImage> MyTextsWithImages => _myItems ??= Helpers.PrepareList(
      AsList<TextImage>(MyItems),
      MyHeader?.AlternatePositions ?? false,
      MyView.Settings?.TextFirst ?? true
    );
    private List<TextImage> _myItems;

    /// <summary>
    /// Replace the MyHeader with a typed version
    /// </summary>
    protected new TextMediaListHeader MyHeader => _myHeader ??= Customize.MyHeader<TextMediaListHeader>();
    private TextMediaListHeader _myHeader;
  }
}