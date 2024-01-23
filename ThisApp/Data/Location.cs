namespace ThisApp.Data
{
  public partial class Location : Custom.Data.Item16
  {
    public string Company => String(fallback: "");

    public string Description => String(fallback: "");
    public string Street => String(fallback: "");
    public string ZipCode => String(fallback: "");
    public string City => String(fallback: "");
    public string Country => String(fallback: "");
    public string Tel => String(fallback: "");
    public string Fax => String(fallback: "");
    public string Mail => String(fallback: "");
    public string Gps => String(fallback: "");
  }

}