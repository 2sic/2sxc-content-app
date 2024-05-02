using System;
using System.Collections.Generic;
using System.IO;
using ToSic.Razor.Blade;

namespace AppCode.Data
{
  public partial class Link
  {
    /// <summary>
    /// Better icon, with auto-detection for documents and internal links
    /// </summary>
    public string IconAuto => _icon ??= OptimalIcon();
    private string _icon;

    /// <summary>
    /// Better window, with auto-detection for on-site vs. external links
    /// </summary>
    public string WindowAuto => _window ??= OptimalWindow();
    private string _window;

    /// <summary>
    /// The description - if provided - is often needed in a <p>
    /// and the new-lines should become <br>
    /// </summary>
    /// <returns></returns>
    public IHtmlTag DescriptionHtml(bool useEmptyParagraph) => IsEmpty(nameof(Description))
      ? (useEmptyParagraph ? Tag.P() : null)
      : Html(nameof(Description), tweak: t => t.Input(Tags.Nl2Br));


    #region Getters for advanced properties

    private string OptimalIcon() =>!string.IsNullOrEmpty(Icon)
      ? Icon
      : IsDocument
        ? "fas fa-file" // if doc, then file-icon
        : (LinkIsInternal()
          ? "fas fa-caret-right" // else if internal, use play-button
          : "fas fa-external-link-alt");   // else if external, show "open new window"

    private string OptimalWindow() => (string.IsNullOrEmpty(Window) || Window == "auto")
      ? LinkIsInternal() && !IsDocument
        ? "_self"
        : "_blank"
      : Window;

    #endregion



    #region Private Helpers

    private bool IsDocument => _isDoc ??= DocumentExtensions.Contains(Path.GetExtension(Link.ToLower()));
    private bool? _isDoc;
    private static List<string> DocumentExtensions = new List<string> { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".ppsx", ".txt" };

    /// <summary>
    /// The current page url, to detect if a link is
    /// </summary>
    internal string CurrentPageUrl { get; set; }

    private bool LinkIsInternal()
    {
      if (_linkIsInternal.HasValue) return _linkIsInternal.Value;
      var currentUrl = CurrentPageUrl ?? throw new ArgumentException("CurrentPageUrl is not set");

      _linkIsInternal = Link.Contains(currentUrl) // Link to the same page
            || Link.StartsWith("/") // absolute link in same site, eg. "/about-us"
            || Link.StartsWith("#") // hash-link on same page eg "#about-us"
            || Link.StartsWith("."); // relative link from this page eg "../about-us"
      return _linkIsInternal.Value;
    }
    private bool? _linkIsInternal;

    #endregion
  }

}