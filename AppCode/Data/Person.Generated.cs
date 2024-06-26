// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Person.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Person
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.04
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-04-24 12:37:48Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Person 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Person data. <br/>
  /// Generated 2024-04-24 12:37:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Description`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Person: AutoGenerated.ZagPerson
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.Person in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagPerson: Custom.Data.CustomItem
  {
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
    /// FullName as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("FullName", scrubHtml: true) etc.
    /// </summary>
    public string FullName => _item.String("FullName", fallback: "");

    /// <summary>
    /// Mobile as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Mobile", scrubHtml: true) etc.
    /// </summary>
    public string Mobile => _item.String("Mobile", fallback: "");

    /// <summary>
    /// Phone as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Phone", scrubHtml: true) etc.
    /// </summary>
    public string Phone => _item.String("Phone", fallback: "");

    /// <summary>
    /// Photo as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Photo")
    /// </summary>
    public string Photo => _item.Url("Photo");

    /// <summary>
    /// Get the file object for Photo - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile PhotoFile => _item.File("Photo");

    /// <summary>
    /// Get the folder object for Photo.
    /// </summary>
    public IFolder PhotoFolder => _item.Folder("Photo");

    /// <summary>
    /// Position as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Position", scrubHtml: true) etc.
    /// </summary>
    public string Position => _item.String("Position", fallback: "");
  }
}