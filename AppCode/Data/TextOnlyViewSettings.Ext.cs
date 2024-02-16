namespace ThisApp.Data
{
  public partial class TextOnlyViewSettings
  {
    public string Styling => TextAlignment == "c" ? "text-center" : "";
  }
}