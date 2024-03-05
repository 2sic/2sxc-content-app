namespace AppCode.Data
{
  /// <summary>
  /// This is used to extend the TextImage and Video classes.
  /// It will extend the data with information how to alternate, making the Razor view simpler.
  /// </summary>
  public interface IAlternatingItems
  {
    public bool TextIsFirst { get; set; }
    public bool IsLast { get; set; }

    public string ImagePlacement { get; }
    public string TextPlacement { get; }
    public string RowClass { get; }
  }
}