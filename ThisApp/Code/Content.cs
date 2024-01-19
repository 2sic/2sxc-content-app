using ToSic.Sxc.Data;
namespace ThisApp.Data
{
  public partial class Content : Custom.Data.Item16Experimental
  {
    public Content(ITypedItem item) : base(item) { }

    public string Text => GetThis(fallback: "");

    public string Image => GetThis(fallback: "");

    public string ImageUrl => Url(nameof(Image), fallback: "");
  }

}