using System.Collections.Generic;
using System.IO;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;
using ToSic.Sxc.Services;

namespace ThisApp.Links
{
  public class LinkSpecs
  {
    public LinkSpecs(ServiceKit16 kit, ITypedItem item)
      : this(kit, item.Url("Link"), item.String("Window"), item.String("Icon"))
    { }

    /// <summary>
    /// Get links specs based on known information
    /// </summary>
    public LinkSpecs(ServiceKit16 kit, string link, string window, string icon)
    {
      Icon = icon;
      Window = window;

      // found something?
      Found = Text.Has(link);
      if (!Found) return;

      var linkExt = Path.GetExtension(link.ToLower());
      var isDoc = DocumentExtensions.Contains(linkExt);

      // try to find out if it's a local link
      bool isInternal = LinkIsInternal(kit, link);

      // auto-detect icon based on file type if it's stays on the same site
      // but only if no icon was specified already
      if (string.IsNullOrEmpty(icon))
        Icon = isDoc
          ? "fas fa-file" // if doc, then file-icon
          : (isInternal
            ? "fas fa-caret-right" // else if internal, use play-button
            : "fas fa-external-link-alt");   // else if external, show "open new window"

      // optionally auto-detect the window
      if (string.IsNullOrEmpty(window) || window == "auto")
        Window = isInternal && !isDoc ? "_self" : "_blank";
    }

    public bool Found { get; }
    public string Icon {get;}
    public string Window {get;}

    private static List<string> DocumentExtensions = new List<string> { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".ppsx", ".txt" };


    private bool LinkIsInternal(ServiceKit16 kit, string link)
      => link.Contains(kit.Link.To()) // Link to the same page
        || link.StartsWith("/") // absolute link in same site, eg. "/about-us"
        || link.StartsWith("#") // hash-link on same page eg "#about-us"
        || link.StartsWith("."); // relative link from this page eg "../about-us"
  }
}