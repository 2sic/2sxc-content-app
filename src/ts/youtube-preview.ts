export function activateYouTubePreviews() {
  var youtubeElem = $("[data-youtube^='iframe-']");
  // If youtube element is on page
  if(youtubeElem.length != 0) {

    // goes through all youtube elements
    youtubeElem.each(function() {
      // off removes click event - so its only added once
      // add click event
      $(this).off('click').on('click', function(){
        var iframeId = $(this).data("youtube");
        var iframeElem = $("#" + iframeId);
        var youtubeUrl = iframeElem.data("youtube-src");
        iframeElem.attr("src", youtubeUrl);
        $(this).addClass('hide');
      })
    });  
  }
}