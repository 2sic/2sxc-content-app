namespace AppCode.Data
{
  public partial class TextViewSettings
  {
    public string Styling => TextAlignment == "c" ? "text-center" : "";
  }
}