namespace AppCode.Data
{
  public partial class TextImage : IAlternatingItems
  {
    public bool TextIsFirst { get; set; }
    public bool IsLast { get; set; }

    public string ImagePlacement => TextIsFirst ? "last" : "first";
    public string TextPlacement => TextIsFirst ? "first" : "last";
    public string RowClass => Styling.RowClass(IsLast);
  }
}