export function activateYouTubePreviews() {
  var youtubeElem = $("[data-youtube^='iframe-']");

  if(youtubeElem.length != 0) {
    youtubeElem.each(function() {
      $(this).on('click', function(){
        var iframeId = $(this).data("youtube");
        var iframeElem = $("#" + iframeId);
        var youtubeUrl = iframeElem.data("youtube-src");
        iframeElem.attr("src", youtubeUrl);
        $(this).addClass('hide');
      })
    });  
  }
}