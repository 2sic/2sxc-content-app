namespace ThisApp.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class RazorBase: Custom.Hybrid.RazorTyped
  {

    /// <summary>
    /// Special helpers for titles, toolbars etc.
    /// </summary>
    protected ContentHelpers Helpers => _helpers ??= GetService<ContentHelpers>();
    private ContentHelpers _helpers;
  }
}