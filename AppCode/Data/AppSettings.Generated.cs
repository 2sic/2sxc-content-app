// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppSettings.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppSettings
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
  // This is a generated class for AppSettings
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppSettings data. <br/>
  /// Generated 2024-02-28 22:58:07Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.MapsEnableDirections`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class AppSettings: AppSettingsAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for AppSettings.
  /// </summary>
  public abstract class AppSettingsAutoGenerated: Custom.Data.Item16
  {
    /// <summary>
    /// MapsEnableDirections as bool. <br/>
    /// To get nullable use .Get("MapsEnableDirections") as bool?;
    /// </summary>
    public bool MapsEnableDirections => _item.Bool("MapsEnableDirections");
  }
}