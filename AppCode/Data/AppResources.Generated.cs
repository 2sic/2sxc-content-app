// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppResources.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppResources
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-02-28 22:58:07Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for AppResources
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppResources data. <br/>
  /// Generated 2024-02-28 22:58:07Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.MapsLabelDirections`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class AppResources: AppResourcesAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for AppResources.
  /// </summary>
  public abstract class AppResourcesAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// MapsLabelDirections as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("MapsLabelDirections", scrubHtml: true) etc.
    /// </summary>
    public string MapsLabelDirections => _item.String("MapsLabelDirections", fallback: "");

    /// <summary>
    /// VideoDefaultPreviewImage as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("VideoDefaultPreviewImage")
    /// </summary>
    public string VideoDefaultPreviewImage => _item.Url("VideoDefaultPreviewImage");

    /// <summary>
    /// Get the file object for VideoDefaultPreviewImage - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile VideoDefaultPreviewImageFile => _item.File("VideoDefaultPreviewImageFile");

    /// <summary>
    /// Get the folder object for VideoDefaultPreviewImage.
    /// </summary>
    public IFolder VideoDefaultPreviewImageFolder => _item.Folder("VideoDefaultPreviewImageFolder");
  }
}