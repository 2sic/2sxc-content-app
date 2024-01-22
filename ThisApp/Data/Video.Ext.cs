namespace ThisApp.Data
{
  public partial class Video : IAlternatingItems
  {
    public string HeadingType => Presentation.String("HeadingType");
    public bool TextIsFirst { get; set; }
    public bool IsLast { get; set; }
    public string ImagePlacement => TextIsFirst ? "last" : "first";
    public string TextPlacement => TextIsFirst ? "first" : "last";
    public string RowClass => Styling.RowClass(IsLast);
  }
}