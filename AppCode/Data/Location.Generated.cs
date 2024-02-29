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

// Generator:   DataModelGenerator v17.02.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-02-29 20:20:26Z
using ToSic.Sxc.Cms.Data;

namespace AppCode.Data
{
  // This is a generated class for Location
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Location data. <br/>
  /// Generated 2024-02-29 20:20:26Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.City`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Location: LocationAutoGenerated
  {  }

  /// <summary>
  /// Auto-Generated base class for Location.
  /// </summary>
  public abstract class LocationAutoGenerated: Custom.Data.CustomItem
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
    /// Fax as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Fax", scrubHtml: true) etc.
    /// </summary>
    public string Fax => _item.String("Fax", fallback: "");

    /// <summary>
    /// GPS as GPS Coordinates object with Latitude and Longitude.
    /// </summary>
    public GpsCoordinates GPS => _item.Gps("GPS");

    /// <summary>
    /// Mail as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Mail", scrubHtml: true) etc.
    /// </summary>
    public string Mail => _item.String("Mail", fallback: "");

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