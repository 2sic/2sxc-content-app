// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Image.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Image
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-02-29 20:23:34Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Image
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Image data. <br/>
  /// Generated 2024-02-29 20:23:34Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Image`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Image: ImageAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for Image.
  /// </summary>
  public abstract class ImageAutoGenerated: Custom.Data.CustomItem
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
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}