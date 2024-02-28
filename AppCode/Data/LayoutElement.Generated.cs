// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "LayoutElement.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class LayoutElement
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataModelGenerator v17.02.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-02-28 22:58:07Z
namespace AppCode.Data
{
  // This is a generated class for LayoutElement
  // To extend/modify it, see instructions above.

  /// <summary>
  /// LayoutElement data. <br/>
  /// Generated 2024-02-28 22:58:07Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Notes`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class LayoutElement: LayoutElementAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for LayoutElement.
  /// </summary>
  public abstract class LayoutElementAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// Notes as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Notes", scrubHtml: true) etc.
    /// </summary>
    public string Notes => _item.String("Notes", fallback: "");
  }
}