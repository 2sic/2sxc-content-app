namespace ThisApp.Data
{
  public partial class ContentListHeader : Custom.Data.Item16Experimental
  {
    public bool AlternatePositions => Bool(fallback: false);
  }
}