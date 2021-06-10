import { monkeyPatchjQueryFade } from './jquery-fade-in';
import { activateObfuscatedMails } from './mail-obfuscator';
import { activateYouTubePreviews } from './youtube-preview';
import { activateFancybox } from './content-fancybox';
import { GoogleMapsTurnOn } from './google-maps';

// so it can be called from the HTML when content re-initializes dynamically
const winAny = (window as any);
const appC = winAny.appContent = winAny.appContent || {};

winAny.appContent.maps = winAny.appContent.maps || new GoogleMapsTurnOn();

/** activate all the content-app features */
function activateAll() {
  // console.log('activate all');
  activateObfuscatedMails();
  activateFancybox();
  activateYouTubePreviews();
  // activateGoogleMaps(appC);
}

// Work around a limitation of jQuery if it's installed in slim mode
$(monkeyPatchjQueryFade);

appC.activateAll = appC.activateAll || activateAll;

// If loaded the first time on a dynamic page, activate automatically
// Later reloads will need to call the activateAll from the reloaded content
$(activateAll);
