declare let Fancybox: any;

// This is only partial - if you want to see more, see https://fancyapps.com/docs/ui/fancybox/options
interface FancyboxOptions {
  groupAll: boolean;
  Thumbs: {
    autostart: boolean;
  }
  startIndex?: number;
  preload?: number;
  infinite?: boolean;
  autoFocus?: boolean;
}

export function initFancybox({ groupId, options } : { groupId: string, options: FancyboxOptions }) {
  Fancybox.bind(`[data-app-content-fancybox="${groupId}"]`, options);
}