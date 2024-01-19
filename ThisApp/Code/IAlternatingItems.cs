namespace ThisApp.Data
{
  public interface IAlternatingItems
  {
    public bool TextIsFirst { get; set; }
    public bool IsLast { get; set; }

    public string ImagePlacement { get; }
    public string TextPlacement { get; }
    public string RowClass { get; }
  }
}