using AppCode.Data;
using Custom.Data;
using ToSic.Sxc.Context;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class TextRazor: TextMediaRazor
  {
    /// <summary>
    /// Replace the MyView with a typed version for Text-only
    /// </summary>
    protected new ICmsView<TextViewSettings, CustomItem> MyView => Customize.MyView<TextViewSettings, CustomItem>();
  }
}