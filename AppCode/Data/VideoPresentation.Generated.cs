// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "VideoPresentation.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class VideoPresentation
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.00
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-02-22 12:56:40Z
namespace AppCode.Data
{
  // This is a generated class for VideoPresentation
  // To extend/modify it, see instructions above.

  /// <summary>
  /// VideoPresentation data. <br/>
  /// Generated 2024-02-22 12:56:40Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.HeadingType`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class VideoPresentation: VideoPresentationAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for VideoPresentation.
  /// </summary>
  public abstract class VideoPresentationAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// HeadingType as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("HeadingType", scrubHtml: true) etc.
    /// </summary>
    public string HeadingType => base.String("HeadingType", fallback: "");

    /// <summary>
    /// VideoLightbox as bool. <br/>
    /// To get nullable use .Get("VideoLightbox") as bool?;
    /// </summary>
    public bool VideoLightbox => base.Bool("VideoLightbox");
  }
}