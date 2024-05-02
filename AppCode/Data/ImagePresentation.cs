namespace AppCode.Data
{
  public partial class ImagePresentation
  {
    /// <summary>
    /// Use Lightbox default to true if not set.
    /// </summary>
    public new bool UseLightbox => _item.Bool("UseLightbox", fallback: true);
  }
}