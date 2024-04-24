using AppCode.Data;
using Custom.Data;
using ToSic.Sxc.Context;

namespace AppCode.Razor
{
  /// <summary>
  /// Base class for Text-only Razor templates
  /// </summary>
  public abstract class TextRazor: TextMediaRazor
  {
    /// <summary>
    /// Replace the MyView with a typed version for Text-only
    /// </summary>
    protected new ICmsView<TextViewSettings, CustomItem> MyView => Customize.MyView<TextViewSettings, CustomItem>();
  }
}