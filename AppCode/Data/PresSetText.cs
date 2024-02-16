namespace ThisApp.Data
{
  public partial class PresSetText : Custom.Data.Item16
  {
    public string HeadingType => String(fallback: "");

    public bool ImageLightbox => Bool(fallback: true);

    public bool TitleLightbox => Bool(fallback: true);
  }

}