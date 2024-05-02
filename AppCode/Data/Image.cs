namespace AppCode.Data
{
  public partial class Image
  {
    // Add your own properties and methods here
    public new ImagePresentation Presentation => As<ImagePresentation>(base.Presentation);
  }
}