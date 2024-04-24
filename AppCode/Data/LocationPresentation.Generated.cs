// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "LocationPresentation.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class LocationPresentation
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
  // This is a generated class for LocationPresentation 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// LocationPresentation data. <br/>
  /// Generated 2024-04-24 12:37:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.MapsEnableDirections`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class LocationPresentation: AutoGenerated.ZagLocationPresentation
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.LocationPresentation in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagLocationPresentation: Custom.Data.CustomItem
  {
    /// <summary>
    /// MapsEnableDirections as bool. <br/>
    /// To get nullable use .Get("MapsEnableDirections") as bool?;
    /// </summary>
    public bool MapsEnableDirections => _item.Bool("MapsEnableDirections");

    /// <summary>
    /// MapsLabelDirections as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("MapsLabelDirections", scrubHtml: true) etc.
    /// </summary>
    public string MapsLabelDirections => _item.String("MapsLabelDirections", fallback: "");
  }
}