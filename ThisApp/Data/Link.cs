namespace ThisApp.Data
{
  public partial class Link : LinkBase
  {
    public string Description => String(fallback: "");

    public string Image => String(fallback: "");

    public string Icon => String(fallback: "");


    public string LinkUrl => Url(nameof(Link), fallback: "");

    public string LinkText => String(fallback: "");

    public string Window => String(fallback: "");
  }

  public class LinkBase : Custom.Data.Item16
  {
    // Properties can't have the same name as the class, so we can't add it directly to the Link class
    // Which is why we have this base class as a workaround
    public string Link => String(fallback: "");
  }
}