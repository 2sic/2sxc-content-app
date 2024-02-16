using AppCode.Data;
using ToSic.Sxc.Images;

namespace AppCode
{
  /// <summary>
  /// Simple service to prepare data for youtube embed.
  /// To use, must be created using GetService<VideoService>() in your view, as it needs the Kit.
  /// </summary>
  public class VideoService : Custom.Hybrid.CodeTyped
  {
    public IResponsivePicture Preview(Video video, int columns)
    {
      // If no image selection is set, return null
      if (video.IsEmpty("ImageSelection")) return null;

      // Figure out which image to use for the preview
      object previewSource = video.ImageSelection switch
      {
        // upload should use the file uploaded
        "upload" => video.Field("Image"),
        // default should use a preset image in the resources
        "default" => App.Resources.Field("VideoDefaultPreviewImage"),
        // Fallback: use standard youtube image link
        _ => $"https://img.youtube.com/vi/{video.YouTubeId}/maxresdefault.jpg"
      };
      
      // Figure out width based on max-width of a content-image and 12 Bootstrap Columns
      // The value will be something like "12/12" or "4/12" which is used for scaling the image
      var factor = columns + "/12";

      // Create settings based on the default "Content" but with these changes
      var videoSettings = Kit.Image.Settings("Content", aspectRatio: "16:9", factor: factor);

      // Return the picture
      return Kit.Image.Picture(previewSource, settings: videoSettings, imgAltFallback: video.Title);
    }

  }
}