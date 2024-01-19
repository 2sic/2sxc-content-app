using ToSic.Sxc.Data;

namespace ThisApp.Data
{
  public partial class TextMediaViewSettings : Custom.Data.Item16Experimental
  {
    public bool TextFirst => GetThis(fallback: false);
    public int ColsElement1 => GetThis(fallback: 0);
  }

  public partial class TextMediaViewSettings
  {
    public int ColsText => TextFirst ? ColsElement1 : Styling.TotalColumns - ColsElement1;

    public int ColsMedia => TextFirst ? Styling.TotalColumns - ColsElement1 : ColsElement1;

    /// <summary>
    /// if image has 0 columns, it's between title / text
    /// </summary>
    public bool ImgIsBetweenTitleAndText => ColsMedia == 0;
  }
}