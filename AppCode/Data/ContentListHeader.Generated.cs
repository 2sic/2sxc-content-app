// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "ContentListHeader.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class ContentListHeader
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
  // This is a generated class for ContentListHeader
  // To extend/modify it, see instructions above.

  /// <summary>
  /// ContentListHeader data. <br/>
  /// Generated 2024-02-22 12:56:40Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.AlternatePositions`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class ContentListHeader: ContentListHeaderAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for ContentListHeader.
  /// </summary>
  public abstract class ContentListHeaderAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// AlternatePositions as bool. <br/>
    /// To get nullable use .Get("AlternatePositions") as bool?;
    /// </summary>
    public bool AlternatePositions => base.Bool("AlternatePositions");
  }
}