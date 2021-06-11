import { monkeyPatchjQueryFade } from './jquery-fade-in';
import { activateObfuscatedMails } from './mail-obfuscator';
import { activateYouTubeInline } from './youtube-preview';
import { GoogleMapsTurnOn } from './google-maps/google-maps';

// so it can be called from the HTML when content re-initializes dynamically
const winAny = (window as any);
winAny.appContent = winAny.appContent || {};
winAny.appContent.maps = winAny.appContent.maps || new GoogleMapsTurnOn();
winAny.appContent.activateYouTubeInline = activateYouTubeInline;

/** activate all the content-app features */
function activateAll() {
  // console.log('activate all');
  activateObfuscatedMails();
}

// Work around a limitation of jQuery if it's installed in slim mode
// because FancyBox will access this jQuery feature
$(monkeyPatchjQueryFade);

winAny.appContent.activateAll = winAny.appContent.activateAll || activateAll;

// If loaded the first time on a dynamic page, activate automatically
// Later reloads will need to call the activateAll from the reloaded content
$(activateAll);
