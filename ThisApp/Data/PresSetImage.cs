namespace ThisApp.Data
{
  public partial class PresSetImage : Custom.Data.Item16Experimental
  {

    public bool TitleLegend => Bool(fallback: true);

    public bool ImageLightbox => Bool(fallback: false);

    public bool TitleLightbox => Bool(fallback: true);
  }

}