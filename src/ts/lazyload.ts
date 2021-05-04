/* Lazyload */
export function activateLazyLoad() {
  /* Lazy - only if jQuery Animations exists */
  if (($('.lazy') as any).Lazy) {
    ($('.lazy') as any).Lazy({
      effect: 'fadeIn',
      effectTime: 200,
    });
  }
}
