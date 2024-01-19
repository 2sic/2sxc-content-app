namespace ThisApp.Data
{
  public partial class Link : LinkBase
  {
    public string Description => String(fallback: "");

    public string Image => String(fallback: "");

    public string Icon => String(fallback: "");

    // TODO: @2dm NOTE that properties can't have the same name as the class

    public string LinkUrl => Url(nameof(Link), fallback: "");

    public string LinkText => String(fallback: "");

    public string Window => String(fallback: "");
  }

  public class LinkBase : Custom.Data.Item16Experimental
  {
    public string Link => String(fallback: "");
  }
}