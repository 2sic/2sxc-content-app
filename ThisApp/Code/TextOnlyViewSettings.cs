using ToSic.Sxc.Data;

namespace ThisApp.Data
{

  public partial class TextOnlyViewSettings : Custom.Data.Item16Experimental
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