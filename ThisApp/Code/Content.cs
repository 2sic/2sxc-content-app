using ToSic.Sxc.Data;
using ToSic.Sxc.Data.Experimental;
using ToSic.Sxc.Images;
namespace ThisApp.Data
{
  public partial class Content : TypedItem
  {
    public Content(ITypedItem item) : base(item) { }

    public string Text => GetThis(fallback: "");

    public string Image => GetThis(fallback: "");

    public string ImageUrl => Url(nameof(Image), fallback: "");
  }

}