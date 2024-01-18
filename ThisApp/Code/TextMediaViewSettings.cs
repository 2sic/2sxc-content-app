using ToSic.Sxc.Data;
using ToSic.Sxc.Data.Experimental;
namespace ThisApp.Data
{
  public partial class TextMediaViewSettings : TypedItem
  {
    public TextMediaViewSettings(ITypedItem item) : base(item) { }

    public bool TextFirst => GetThis(fallback: false);
    public int ColsElement1 => GetThis(fallback: 0);
  }

  public partial class TextMediaViewSettings
  {
    public int ColsText => TextFirst ? ColsElement1 : Constants.TotalColumns - ColsElement1;

    public int ColsMedia => TextFirst ? Constants.TotalColumns - ColsElement1 : ColsElement1;

    /// <summary>
    /// if image has 0 columns, it's between title / text
    /// </summary>
    public bool ImgIsBetweenTitleAndText => ColsMedia == 0;
  }
}