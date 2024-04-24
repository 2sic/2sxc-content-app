using System.Collections.Generic;
using System.Linq;
using AppCode.Data;

namespace AppCode.Razor
{
  /// <summary>
  /// Base class for Links Razor templates
  /// </summary>
  public abstract class LinksRazor: AppRazor
  {
    protected Link MyLink => _myLink ??= MyLinks.FirstOrDefault();
    private Link _myLink;

    /// <summary>
    /// Links to show, based on the data edited on the current page.
    /// The setup is a bit more complex, to make it easier to user calculated properties.
    /// </summary>
    protected List<Link> MyLinks => _links ??= AsList<Link>(MyItems)
      .Select(i => {
        i.CurrentPageUrl = CurrentPageUrl;  // Set this property, so it can be used in calculated properties of Link
        return i;
      })
      .ToList();
    private List<Link> _links;

    /// <summary>
    /// The current page url. Since we use it in a Select-loop, we want to avoid re-calculating it for each item.
    /// </summary>
    private string CurrentPageUrl => _currentPageUrl ??= Link.To();
    private string _currentPageUrl;
  }
}