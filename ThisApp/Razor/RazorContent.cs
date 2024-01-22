namespace ThisApp
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class RazorBase: Custom.Hybrid.RazorTyped
  {

    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;
  }
}