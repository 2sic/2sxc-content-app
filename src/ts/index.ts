import { monkeyPatchjQueryFade } from './jquery-fade-in';
import { activateObfuscatedMails } from './mail-obfuscator';
import { activateYouTubePreviews } from './youtube-preview';
import { activateFancybox } from './content-fancybox';
import { activateGoogleMaps, processQueue } from './google-maps';

/** activate all the content-app features */
function activateAll() {
  // console.log('activate all');
  activateObfuscatedMails();
  activateFancybox();
  activateYouTubePreviews();
  activateGoogleMaps();
}

// Work around a limitation of jQuery if it's installed in slim mode
$(monkeyPatchjQueryFade);

// Add window.appContent.activateAll() 
// so it can be called from the HTML when content re-initializes dynamically
const win2Ext = (window as any);
const appC = win2Ext.appContent = win2Ext.appContent || {};
appC.activateAll = appC.activateAll || activateAll;
appC.processQueue = appC.processQueue || processQueue;

// If loaded the first time on a dynamic page, activate automatically
// Later reloads will need to call the activateAll from the reloaded content
$(activateAll);
