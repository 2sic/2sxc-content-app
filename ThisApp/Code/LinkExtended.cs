using System.Collections.Generic;
using System.IO;
using ToSic.Razor.Blade;
using ThisApp.Data;
using System;

namespace ThisApp.Links
{
  public partial class LinkExtended : Link
  {
    /// <summary>
    /// Report if there really was a link
    /// </summary>
    public bool Found => Text.Has(Link);

    public new string Icon => _icon ??= GetIcon();
    private string _icon;

    public new string Window => _window ??= GetWindow();
    private string _window;

    #region Getters for advanced properties

    private string GetIcon() =>!string.IsNullOrEmpty(base.Icon)
      ? base.Icon
      : IsDocument
        ? "fas fa-file" // if doc, then file-icon
        : (LinkIsInternal()
          ? "fas fa-caret-right" // else if internal, use play-button
          : "fas fa-external-link-alt");   // else if external, show "open new window"

    private string GetWindow() => (string.IsNullOrEmpty(base.Window) || base.Window == "auto")
      ? LinkIsInternal() && !IsDocument
        ? "_self"
        : "_blank"
      : base.Window;

    #endregion

    #region Private Helpers

    private bool IsDocument => _isDoc ??= DocumentExtensions.Contains(Path.GetExtension(Link.ToLower()));
    private bool? _isDoc;
    private static List<string> DocumentExtensions = new List<string> { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".ppsx", ".txt" };

    private bool LinkIsInternal()
    {
      if (_linkIsInternal.HasValue) return _linkIsInternal.Value;
      _linkIsInternal = Link.Contains(Kit.Link.To()) // Link to the same page
            || Link.StartsWith("/") // absolute link in same site, eg. "/about-us"
            || Link.StartsWith("#") // hash-link on same page eg "#about-us"
            || Link.StartsWith("."); // relative link from this page eg "../about-us"
      return _linkIsInternal.Value;
    }
    private bool? _linkIsInternal;

    #endregion
  }

}