using System.Text.RegularExpressions;

namespace AppCode.Data
{
  public partial class Video : IAlternatingItems
  {
    #region IAlternatingItems Members

    public bool TextIsFirst { get; set; }
    public bool IsLast { get; set; }
    public string ImagePlacement => TextIsFirst ? "last" : "first";
    public string TextPlacement => TextIsFirst ? "first" : "last";
    public string RowClass => Styling.RowClass(IsLast);

    #endregion

    /// <summary>
    /// Override Presentation with Typed Item
    /// </summary>
    public new TextMediaPresentation Presentation => _presentation ??= As<TextMediaPresentation>(base.Presentation);
    private TextMediaPresentation _presentation;
    
    public bool IsValidYouTube => !string.IsNullOrEmpty(YouTubeId);

    public string YouTubeId => _youTubeId ??= GetYouTubeId();
    private string _youTubeId;

    public string YouTubeUrl => IsValidYouTube
      ? $"https://www.youtube.com/embed/{YouTubeId}?controls=1&fs=1&modestbranding=0&rel=0&showinfo=0&autohide=1&iv_load_policy=3&theme=dark&wmode=transparent&autoplay=true"
      : null;

    private string GetYouTubeId()
    {
      // Check if the link is a youtube, and convert that to a youtube embed
      var youTubeLink = Regex.Match(Url("VideoLink"), @"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)");
      return youTubeLink.Success
        ? youTubeLink.Groups[1].Value        
        : null;
    }
  }
}