using ToSic.Sxc.Data;
using ToSic.Sxc.Services;

namespace ThisApp.Data
{
  public partial class Link : LinkBase
  {
    // public Link(ITypedItem item) : base(item) { }
    public Link(ITypedItem item, ServiceKit16 kit) : base(item, kit) { }

    public string Description => GetThis(fallback: "");

    public string Image => GetThis(fallback: "");

    public string Icon => GetThis(fallback: "");

    // TODO: @2dm NOTE that properties can't have the same name as the class

    public string LinkUrl => Url(nameof(Link), fallback: "");

    public string LinkText => GetThis(fallback: "");

    public string Window => GetThis(fallback: "");
  }

  public class LinkBase : Custom.Data.Item16Experimental
  {
    public LinkBase(ITypedItem item, ServiceKit16 kit) : base(item, kit) { }

    public string Link => GetThis(fallback: "");
  }
}