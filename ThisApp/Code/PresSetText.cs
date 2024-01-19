using ToSic.Sxc.Data;

namespace ThisApp.Data
{
  public partial class PresSetText : Custom.Data.Item16Experimental
  {
    public PresSetText(ITypedItem item) : base(item) { }

    public string HeadingType => GetThis(fallback: "");

    public bool ImageLightbox => GetThis(fallback: true);

    public bool TitleLightbox => GetThis(fallback: true);
  }

}