namespace AppCode.Data
{
  public partial class TextMediaViewSettings : Custom.Data.Item16
  {
    public bool TextFirst => Bool(fallback: false);
    public int ColsElement1 => Int(fallback: 0);
  }
}