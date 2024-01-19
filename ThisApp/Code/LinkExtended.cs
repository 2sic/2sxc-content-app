using System.Collections.Generic;
using System.IO;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Sxc.Data;
using ToSic.Sxc.Services;

namespace ThisApp.Data
{
  public partial class LinkExtended : Link
  {
    public LinkExtended(ITypedItem item, ServiceKit16 kit) : base(item, kit) { }

    public bool Found => Text.Has(Link);

    public new string Icon
    {
      get
      {
        if (_icon != null) return _icon;
        if (string.IsNullOrEmpty(base.Icon))
          _icon = IsDocument
            ? "fas fa-file" // if doc, then file-icon
            : (LinkIsInternal()
              ? "fas fa-caret-right" // else if internal, use play-button
              : "fas fa-external-link-alt");   // else if external, show "open new window"
        return _icon = base.Icon;
      }
    }
    private string _icon;

    // TODO: @2dm NOTE that properties can't have the same name as the class

    public new string Window
    {
      get
      {
        if (_window != null) return _window;
        return _window = (string.IsNullOrEmpty(base.Window) || base.Window == "auto")
          ? LinkIsInternal() && !IsDocument ? "_self" : "_blank"
          : base.Window;
      }
    }
    private string _window;


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
  }

}