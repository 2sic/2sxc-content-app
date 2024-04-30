// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TextMediaPresentation.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TextMediaPresentation
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
  // This is a generated class for TextMediaPresentation 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TextMediaPresentation data. <br/>
  /// Generated 2024-04-24 12:37:48Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.HeadingType`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TextMediaPresentation: AutoGenerated.ZagTextMediaPresentation
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TextMediaPresentation in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagTextMediaPresentation: Custom.Data.CustomItem
  {
    /// <summary>
    /// HeadingType as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("HeadingType", scrubHtml: true) etc.
    /// </summary>
    public string HeadingType => _item.String("HeadingType", fallback: "");

    /// <summary>
    /// TitleLightbox as bool. <br/>
    /// To get nullable use .Get("TitleLightbox") as bool?;
    /// </summary>
    public bool TitleLightbox => _item.Bool("TitleLightbox");

    /// <summary>
    /// UseLightbox as bool. <br/>
    /// To get nullable use .Get("UseLightbox") as bool?;
    /// </summary>
    public bool UseLightbox => _item.Bool("UseLightbox");
  }
}