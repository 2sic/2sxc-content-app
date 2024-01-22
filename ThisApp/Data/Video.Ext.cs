using System.Text.RegularExpressions;

namespace ThisApp.Data
{
  public partial class Video
  {
    public string HeadingType => Presentation.String("HeadingType");

    public bool UseLightbox => Presentation.Bool("VideoLightbox");

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