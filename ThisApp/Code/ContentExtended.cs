using ToSic.Sxc.Data;
namespace ThisApp.Data
{
  public class ContentExtended : Content
  {
    public ContentExtended(ITypedItem item, bool textIsFirst, bool isLast) : base(item) {
      _textIsFirst = textIsFirst;
      _isLast = isLast;
    }

    private readonly bool _textIsFirst;
    private bool _isLast;

    public string ImagePlacement => _textIsFirst ? "last" : "first";
    public string TextPlacement => _textIsFirst ? "first" : "last";
    public string RowClass => Styling.RowClass(_isLast);
  }
}