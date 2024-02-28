using ToSic.Sxc.Data;
using ToSic.Sxc.Images;

namespace AppCode
{
  /// <summary>
  /// Helper class to prepare data/settings for showing an image, possibly with a lightbox link.
  /// </summary>
  public class PictureInLightbox
  {
    public PictureInLightbox(ITypedItem item, string fieldName, int columns)
    {
      _item = item;
      _fieldName = fieldName;
      _columns = columns;
    }

    private readonly ITypedItem _item;
    private readonly string _fieldName;
    private readonly int _columns;

    /// <summary>
    /// Tell the system if we actually have an image or not.
    /// </summary>
    public bool HasImage => _item.IsNotEmpty("Image");

    /// <summary>
    /// Figure out to what size the image should be resized.
    /// 100% or "12/12" or just "1" is the max width of the layout. 
    /// If we have fewer columns, then it must be proportionally smaller, eg 4/12
    /// </summary>
    private string ResizeFactor => _columns == 0 ? "1" : _columns + "/12";

    /// <summary>
    /// Determine if we use a lightbox based on the presentation settings
    /// </summary>
    public bool UseLightbox => _item.Presentation.Bool("UseLightbox", fallback: true);

    /// <summary>
    /// The standard Picture object which is used multiple times, incl. to access Metadata.
    /// </summary>
    public IResponsivePicture Picture => _picDisplay
      ??= _item.Picture(_fieldName, settings: "Content", factor: ResizeFactor, imgAltFallback: _item.Title);
    private IResponsivePicture _picDisplay;

    /// <summary>
    /// The full size picture to be used in the lightbox.
    /// </summary>
    public IResponsivePicture LightboxPic => _lightboxPic
      ??= _item.Picture(_fieldName, settings: "Lightbox");
    private IResponsivePicture _lightboxPic;

    /// <summary>
    /// Caption of the lightbox - if activated, otherwise just "".
    /// </summary>
    public string LightboxCaption => _item.Presentation.Bool("TitleLightbox", fallback: true)
      ? Picture.Alt
      : "";
  }
}