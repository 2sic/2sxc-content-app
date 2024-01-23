namespace ThisApp.Data
{
  public partial class ContentListHeader : Custom.Data.Item16
  {
    public bool AlternatePositions => Bool(fallback: false);
  }
}