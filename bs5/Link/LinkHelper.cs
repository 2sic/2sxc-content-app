using System.Collections.Generic;
using System.IO;
using ToSic.Razor.Blade;
using ToSic.Sxc.Data;

public class LinkHelper: Custom.Hybrid.CodeTyped
{
  public object LinkInfos(ITypedItem item) {
    return LinkInfos(item.Url("Link"), item.String("Window"), item.String("Icon"));
  }
  
  // check a link, prepare target window, icon etc. based on various settings
  public object LinkInfos(string link, string window, string icon) {
    var fileExtensions = new List<string> { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".ppsx", ".txt" };

    // found something?
    var found = Text.Has(link);

    // process remaining properties, in case we want to override them with automatic stuff
    if (found) {
      var linkExt = Path.GetExtension(link.ToLower());
      var isDoc = fileExtensions.Contains(linkExt);

      // try to find out if it's a local link
      bool isInternal = link.Contains(Link.To())
        || link.StartsWith("/") // absolute link in same site
        || link.StartsWith("#") // hash-link on same page
        || link.StartsWith("."); // relative link from this page

      // auto-detect icon based on file type if it's stays on the same site
      // but only if no icon was specified already
      if (string.IsNullOrEmpty(icon))
        icon = isDoc
        ? "fas fa-file" // if doc, then file-icon
        : (isInternal
          ? "fas fa-caret-right" // else if internal, use play-button
          : "fas fa-external-link-alt");   // else if external, show "open new window"

      // optionally auto-detect the window
      if (string.IsNullOrEmpty(window) || window == "auto")
        window = isInternal && !isDoc ? "_self" : "_blank";
    }

    // Return a dynamic object with these properties. It must be dynamic, otherwise the other page cannot use the 
    return new {
      Found = found,
      Icon = icon,
      Window = window,
    };
  }
}
