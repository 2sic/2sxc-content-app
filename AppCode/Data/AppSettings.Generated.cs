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

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-03-05 18:49:04Z
namespace AppCode.Data
{
  // This is a generated class for AppSettings (scope: System.App)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppSettings data. <br/>
  /// Generated 2024-03-05 18:49:04Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.MapsEnableDirections`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.App.
  /// </remarks>
  public partial class AppSettings: AutoGenerated.ZagAppSettings
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.App.AppSettings in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagAppSettings: Custom.Data.CustomItem
  {
    /// <summary>
    /// MapsEnableDirections as bool. <br/>
    /// To get nullable use .Get("MapsEnableDirections") as bool?;
    /// </summary>
    public bool MapsEnableDirections => _item.Bool("MapsEnableDirections");
  }
}