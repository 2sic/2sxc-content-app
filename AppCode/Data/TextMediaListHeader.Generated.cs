// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TextMediaListHeader.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TextMediaListHeader
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-03-05 15:28:27Z
namespace AppCode.Data
{
  // This is a generated class for TextMediaListHeader 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TextMediaListHeader data. <br/>
  /// Generated 2024-03-05 15:28:27Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.AlternatePositions`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TextMediaListHeader: AutoGenerated.ZagTextMediaListHeader
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TextMediaListHeader in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagTextMediaListHeader: Custom.Data.CustomItem
  {
    /// <summary>
    /// AlternatePositions as bool. <br/>
    /// To get nullable use .Get("AlternatePositions") as bool?;
    /// </summary>
    public bool AlternatePositions => _item.Bool("AlternatePositions");
  }
}