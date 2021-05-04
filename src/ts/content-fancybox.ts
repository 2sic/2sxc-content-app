/* Fancybox */
export function activateFancybox() {
  // TODO: 2dm - must ask 2ro/2tl why different from gallery
  // and if this won't break each other
  if ($('.fancybox').fancybox) {
    $('.fancybox').fancybox();
  }
}
