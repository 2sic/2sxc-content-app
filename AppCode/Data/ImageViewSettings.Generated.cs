// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ImageViewSettings.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ImageViewSettings
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.04
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-04-24 12:37:48Z
namespace AppCode.Data
{
  // This is a generated class for ImageViewSettings (scope: System.Configuration)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ImageViewSettings data. <br/>
  /// Generated 2024-04-24 12:37:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.ImageHeight`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.Configuration.
  /// </remarks>
  public partial class ImageViewSettings: AutoGenerated.ZagImageViewSettings
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.Configuration.ImageViewSettings in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagImageViewSettings: Custom.Data.CustomItem
  {
    /// <summary>
    /// ImageHeight as int. <br/>
    /// To get other types use methods such as .Decimal("ImageHeight")
    /// </summary>
    public int ImageHeight => _item.Int("ImageHeight");

    /// <summary>
    /// MaxPerRow as int. <br/>
    /// To get other types use methods such as .Decimal("MaxPerRow")
    /// </summary>
    public int MaxPerRow => _item.Int("MaxPerRow");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");
  }
}