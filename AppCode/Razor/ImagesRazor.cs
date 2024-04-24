using System.Collections.Generic;
using System.Linq;
using AppCode.Data;
using Custom.Data;
using ToSic.Sxc.Context;

namespace AppCode.Razor
{
  /// <summary>
  /// Base class for Images Razor templates
  /// </summary>
  public abstract class ImagesRazor: AppRazor
  {
    /// <summary>
    /// Replace the MyView with a typed version
    /// </summary>
    protected new ICmsView<ImageViewSettings, CustomItem> MyView => Customize.MyView<ImageViewSettings, CustomItem>();

    protected List<Image> MyImages => _myImages ??= AsList<Image>(MyItems).ToList();
    private List<Image> _myImages;

    /// <summary>
    /// Replace the MyHeader with a typed version
    /// </summary>
    protected new TextMediaListHeader MyHeader => _myHeader ??= Customize.MyHeader<TextMediaListHeader>();
    private TextMediaListHeader _myHeader;
  }
}