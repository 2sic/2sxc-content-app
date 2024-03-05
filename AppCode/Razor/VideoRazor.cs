using System.Collections.Generic;
using System.Linq;
using AppCode.Data;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class VideoRazor: TextMediaRazor
  {
    protected Video MyVideo => _myVideo ??= As<Video>(MyItem);
    private Video _myVideo;

    protected List<Video> MyVideos => _myVideos ??= AsList<Video>(MyItems).ToList();
    private List<Video> _myVideos;
  }

  public class VideoModel
  {
    public Video Video { get; set; }
    public int? Columns { get; set; }
  }
}