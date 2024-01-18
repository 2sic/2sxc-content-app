using ToSic.Sxc.Data;
using ToSic.Sxc.Data.Experimental;
namespace ThisApp.Data
{
  public partial class PresSetText : TypedItem
  {
    public PresSetText(ITypedItem item) : base(item) { }

    public string HeadingType => GetThis(fallback: "");

    public bool ImageLightbox => GetThis(fallback: true);

    public bool TitleLightbox => GetThis(fallback: true);
  }

}