using ToSic.Sxc.Data;

namespace ThisApp.Data
{
  public partial class ContentListHeader : Custom.Data.Item16Experimental
  {
    public ContentListHeader(ITypedItem item) : base(item) { }

    public bool AlternatePositions => GetThis(fallback: false);
  }
}