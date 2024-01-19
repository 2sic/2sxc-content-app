namespace ThisApp.Data
{
  public partial class Person : Custom.Data.Item16Experimental
  {
    public string FullName => String(fallback: "");

    public string Position => String(fallback: "");
    public string Description => String(fallback: "");
    public string Photo => String(fallback: "");
    public string Phone => String(fallback: "");
    public string Mobile => String(fallback: "");
    public string Email => String(fallback: "");
  }

}