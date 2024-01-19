namespace ThisApp.Data
{
  public partial class Content : Custom.Data.Item16Experimental
  {
    public string Text => GetThis(fallback: "");

    public string Image => GetThis(fallback: "");

    public string ImageUrl => Url(nameof(Image), fallback: "");
  }

}