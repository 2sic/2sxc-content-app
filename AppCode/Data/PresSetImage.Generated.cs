// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "PresSetImage.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class PresSetImage
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
  // This is a generated class for PresSetImage
  // To extend/modify it, see instructions above.

  /// <summary>
  /// PresSetImage data. <br/>
  /// Generated 2024-02-22 12:56:40Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.ImageLightbox`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class PresSetImage: PresSetImageAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for PresSetImage.
  /// </summary>
  public abstract class PresSetImageAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// ImageLightbox as bool. <br/>
    /// To get nullable use .Get("ImageLightbox") as bool?;
    /// </summary>
    public bool ImageLightbox => base.Bool("ImageLightbox");

    /// <summary>
    /// TitleLegend as bool. <br/>
    /// To get nullable use .Get("TitleLegend") as bool?;
    /// </summary>
    public bool TitleLegend => base.Bool("TitleLegend");

    /// <summary>
    /// TitleLightbox as bool. <br/>
    /// To get nullable use .Get("TitleLightbox") as bool?;
    /// </summary>
    public bool TitleLightbox => base.Bool("TitleLightbox");
  }
}