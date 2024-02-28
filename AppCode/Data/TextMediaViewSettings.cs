namespace AppCode.Data
{
  public partial class TextMediaViewSettings : Custom.Data.Item16
  {
    public bool TextFirst => Bool(nameof(TextFirst), fallback: false);
    public int ColsElement1 => Int(nameof(ColsElement1), fallback: 0);
  }
}