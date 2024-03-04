// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Video.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Video
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.03.00
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-03-04 11:00:49Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Video
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Video data. <br/>
  /// Generated 2024-03-04 11:00:49Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Image`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Video: AutoGenerated.ZagVideo
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Video in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagVideo: Custom.Data.CustomItem
  {
    /// <summary>
    /// Image as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Image")
    /// </summary>
    public string Image => _item.Url("Image");

    /// <summary>
    /// Get the file object for Image - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile ImageFile => _item.File("ImageFile");

    /// <summary>
    /// Get the folder object for Image.
    /// </summary>
    public IFolder ImageFolder => _item.Folder("ImageFolder");

    /// <summary>
    /// ImageSelection as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("ImageSelection", scrubHtml: true) etc.
    /// </summary>
    public string ImageSelection => _item.String("ImageSelection", fallback: "");

    /// <summary>
    /// Text as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Text", scrubHtml: true) etc.
    /// </summary>
    public string Text => _item.String("Text", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");

    /// <summary>
    /// VideoLink as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("VideoLink")
    /// </summary>
    public string VideoLink => _item.Url("VideoLink");

    /// <summary>
    /// Get the file object for VideoLink - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile VideoLinkFile => _item.File("VideoLinkFile");

    /// <summary>
    /// Get the folder object for VideoLink.
    /// </summary>
    public IFolder VideoLinkFolder => _item.Folder("VideoLinkFolder");
  }
}