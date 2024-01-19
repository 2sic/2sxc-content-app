using ToSic.Sxc.Data;

namespace ThisApp.Data
{
  public partial class LinkExtended : Link
  {
    public LinkExtended(ITypedItem item) : base(item) { }

    public string Description => GetThis(fallback: "");

    public string Image => GetThis(fallback: "");

    public string Icon => GetThis(fallback: "");

    // TODO: @2dm NOTE that properties can't have the same name as the class

    public string LinkUrl => Url(nameof(Link), fallback: "");

    public string LinkText => GetThis(fallback: "");

    public string Window => GetThis(fallback: "");
  }

}