using ToSic.Sxc.Data;
using ToSic.Sxc.Data.Experimental;
namespace ThisApp.Data
{
  public partial class ContentListHeader : TypedItem
  {
    public ContentListHeader(ITypedItem item) : base(item) { }

    public bool AlternatePositions => GetThis(fallback: false);
  }
}