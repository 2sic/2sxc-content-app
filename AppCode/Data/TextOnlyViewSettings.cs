namespace AppCode.Data
{
  public partial class TextOnlyViewSettings : Custom.Data.Item16
  {
    public int ColsElement1 => Int(fallback: 0);
    public int ColsPaddingLeft => Int(fallback: 0);
    public string TextAlignment => String(fallback: "");
  }

}