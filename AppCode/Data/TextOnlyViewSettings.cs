namespace AppCode.Data
{
  public partial class TextOnlyViewSettings : Custom.Data.CustomItem
  {
    public int ColsElement1 => Int(nameof(ColsElement1), fallback: 0);
    public int ColsPaddingLeft => Int(nameof(ColsPaddingLeft), fallback: 0);
    public string TextAlignment => String(nameof(TextAlignment), fallback: "");
  }

}