import { showEncryptedMails } from './mail-obfuscator';
import { activateYouTubeInline } from './youtube-preview';
import { GoogleMapsTurnOn } from './google-maps/google-maps';
import { initFancybox } from './fancybox';

// so it can be called from the HTML when content re-initializes dynamically
const winAny = (window as any);
winAny.appContent = winAny.appContent || {};
winAny.appContent.maps = winAny.appContent.maps || new GoogleMapsTurnOn();
winAny.appContent.activateYouTubeInline = winAny.appContent.activateYouTubeInline || activateYouTubeInline;
winAny.appContent.showEncryptedMails = winAny.appContent.showEncryptedMails || showEncryptedMails;
winAny.appContent.initFancybox = initFancybox;

