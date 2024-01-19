using ToSic.Sxc.Data;

namespace ThisApp.Data
{
  public partial class PresSetText : Custom.Data.Item16Experimental
  {
    public PresSetText(ITypedItem item) : base(item) { }

    public string HeadingType => String(fallback: "");

    public bool ImageLightbox => Bool(fallback: true);

    public bool TitleLightbox => Bool(fallback: true);
  }

}