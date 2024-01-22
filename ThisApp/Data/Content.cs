namespace ThisApp.Data
{
  public partial class Content : Custom.Data.Item16Experimental
  {
    public string Text => String(fallback: "");

    public string Image => String(fallback: "");

    public string ImageUrl => Url(nameof(Image), fallback: "");
  }

}