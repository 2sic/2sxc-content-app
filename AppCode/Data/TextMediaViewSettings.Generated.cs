// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TextMediaViewSettings.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TextMediaViewSettings
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   DataClassesGenerator v17.03.01
// App/Edition: Content/
// User:        2sic Web-Developer
// When:        2024-03-05 13:40:10Z
namespace AppCode.Data
{
  // This is a generated class for TextMediaViewSettings (scope: System.Configuration)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TextMediaViewSettings data. <br/>
  /// Generated 2024-03-05 13:40:10Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.ColsElement1`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.Configuration.
  /// </remarks>
  public partial class TextMediaViewSettings: AutoGenerated.ZagTextMediaViewSettings
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.Configuration.TextMediaViewSettings in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagTextMediaViewSettings: Custom.Data.CustomItem
  {
    /// <summary>
    /// ColsElement1 as int. <br/>
    /// To get other types use methods such as .Decimal("ColsElement1")
    /// </summary>
    public int ColsElement1 => _item.Int("ColsElement1");

    /// <summary>
    /// TextFirst as bool. <br/>
    /// To get nullable use .Get("TextFirst") as bool?;
    /// </summary>
    public bool TextFirst => _item.Bool("TextFirst");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    public new string Title => _item.String("Title", fallback: "");
  }
}