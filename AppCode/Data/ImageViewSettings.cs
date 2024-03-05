namespace AppCode.Data
{
  public partial class ImageViewSettings
  {
    /// <summary>
    /// Image height, defaulting to 400
    /// </summary>
    public new int ImageHeight => _item.Int("ImageHeight", fallback: 400);
  }
}