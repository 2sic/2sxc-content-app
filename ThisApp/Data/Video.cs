namespace ThisApp.Data
{
  public partial class Video : Custom.Data.Item16Experimental
  {
    public string VideoLink => String(fallback: "");
    public string VideoLinkUrl => Url(nameof(VideoLink), fallback: "");

    public string ImageSelection => String(fallback: "");
    public string Street => String(fallback: "");
    public string Image => String(fallback: "");

    public string ImageUrl => Url(nameof(Image), fallback: "");
    public string Text => String(fallback: "");
  }
}