// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Location.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Location
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.04
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-04-24 12:37:48Z
using ToSic.Sxc.Cms.Data;

namespace AppCode.Data
{
  // This is a generated class for Location 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Location data. <br/>
  /// Generated 2024-04-24 12:37:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.City`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Location: AutoGenerated.ZagLocation
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.Location in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagLocation: Custom.Data.CustomItem
  {
    /// <summary>
    /// City as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("City", scrubHtml: true) etc.
    /// </summary>
    public string City => _item.String("City", fallback: "");

    /// <summary>
    /// Company as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Company", scrubHtml: true) etc.
    /// </summary>
    public string Company => _item.String("Company", fallback: "");

    /// <summary>
    /// Country as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Country", scrubHtml: true) etc.
    /// </summary>
    public string Country => _item.String("Country", fallback: "");

    /// <summary>
    /// Description as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Description", scrubHtml: true) etc.
    /// </summary>
    public string Description => _item.String("Description", fallback: "");

    /// <summary>
    /// Email as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Email", scrubHtml: true) etc.
    /// </summary>
    public string Email => _item.String("Email", fallback: "");

    /// <summary>
    /// Fax as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Fax", scrubHtml: true) etc.
    /// </summary>
    public string Fax => _item.String("Fax", fallback: "");

    /// <summary>
    /// GpsCoordinates as GPS Coordinates object with Latitude and Longitude.
    /// </summary>
    public GpsCoordinates GpsCoordinates => _item.Gps("GpsCoordinates");

    /// <summary>
    /// Street as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Street", scrubHtml: true) etc.
    /// </summary>
    public string Street => _item.String("Street", fallback: "");

    /// <summary>
    /// Tel as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Tel", scrubHtml: true) etc.
    /// </summary>
    public string Tel => _item.String("Tel", fallback: "");

    /// <summary>
    /// ZipCode as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("ZipCode", scrubHtml: true) etc.
    /// </summary>
    public string ZipCode => _item.String("ZipCode", fallback: "");
  }
}