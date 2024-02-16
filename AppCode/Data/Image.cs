namespace AppCode.Data
{
  public partial class Image : ImageBase
  {
    public string ImageUrl => Url(nameof(Image), fallback: "");
  }

  public partial class ImageBase : Custom.Data.Item16
  {
    public string Image => String(fallback: "");
  }

}