using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using ToSic.Razor.Blade;

public class LinkHelper
{
  // check a link, prepare target window, icon etc. based on various settings
  public LinkInfo LinkInfos(string link, string window, string icon) {
    var fileExtensions = new List<string> { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".ppsx", ".txt" };

    // this will contain the result
    var lInfo = new LinkInfo();

    // found something?
    var found = Text.Has(link);
    lInfo.Found = found;

    // process remaining properties, in case we want to override them with automatic stuff
    if(found) {
      var linkExt = Path.GetExtension(link.ToLower());
      var isDoc = fileExtensions.Contains(linkExt);

      // try to find out if it's a local link
      // TODO: V12 - this shouldn't use Dnn.*
      #if NETCOREAPP
      bool isInternal = false; // TODO: OQTANE
      #else
      bool isInternal = link.Contains(Dnn.Portal.PortalAlias.HTTPAlias)
        || link.StartsWith("/") // absolute link in same site
        || link.StartsWith("#") // hash-link on same page
        || link.StartsWith("."); // relative link from this page
      #endif

      // auto-detect icon based on file type if it's stays on the same site
      // but only if no icon was specified already
      if(string.IsNullOrEmpty(icon))
        icon = isDoc
        ? "fas fa-file" // if doc, then file-icon
        : (isInternal
          ? "fas fa-caret-right" // else if internal, use play-button
          : "fas fa-external-link-alt");   // else if external, show "open new window"

      // optionally auto-detect the window
      if(string.IsNullOrEmpty(window) || window == "auto")
        window = isInternal && !isDoc ? "_self" : "_blank";
    }

    // add properties
    lInfo.Icon = icon;
    lInfo.Window = window;

    return lInfo;
    // we could add these properties too, but at the moment they are not needed
    // linkInfo.Add("Extension", linkExt);
    // linkInfo.Add("IsDoc", isDoc);
  }
}

public class LinkInfo
{
  public string Window;
  public string Icon;
  public bool Found;
}