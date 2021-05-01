

export function activateYouTubePreviews() {
  $("[data-youtube^='iframe-']").on("click", function() {
    var iframeId = $(this).data("youtube");
    var iframeElem = $("#" + iframeId);
    var youtubeUrl = iframeElem.data("youtube-src");
    iframeElem.attr("src", youtubeUrl);
    $(this).addClass('hide');
  });
}