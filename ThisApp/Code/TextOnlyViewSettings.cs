using ToSic.Sxc.Data;
using ToSic.Sxc.Data.Experimental;
namespace ThisApp.Data
{

  public partial class TextOnlyViewSettings : TypedItem
  {
    public TextOnlyViewSettings(ITypedItem item) : base(item) { }

    public int ColsElement1 => GetThis(fallback: 0);
    public int ColsPaddingLeft => GetThis(fallback: 0);
    public string TextAlignment => GetThis(fallback: "");
  }

  public partial class TextOnlyViewSettings
  {
    public string Styling => TextAlignment == "c" ? "text-center" : "";
  }
}