import { monkeyPatchjQueryFade } from './jquery-fade-in';
import { showEncryptedMails } from './mail-obfuscator';
import { activateYouTubeInline } from './youtube-preview';
import { GoogleMapsTurnOn } from './google-maps/google-maps';

declare let Fancybox: any;

// so it can be called from the HTML when content re-initializes dynamically
const winAny = (window as any);
winAny.appContent = winAny.appContent || {};
winAny.appContent.maps = winAny.appContent.maps || new GoogleMapsTurnOn();
winAny.appContent.activateYouTubeInline = winAny.appContent.activateYouTubeInline || activateYouTubeInline;
winAny.appContent.showEncryptedMails = winAny.appContent.showEncryptedMails || showEncryptedMails;

// Work around a limitation of jQuery if it's installed in slim mode
// because FancyBox will access this jQuery feature
// $(monkeyPatchjQueryFade);



(window as any).appFb = {
    initFancybox: function initFancybox(module: any) {
        console.log(`[data-app-${module.type}-fancybox="${module.type}-${module.moduleId}"]`);
        Fancybox.bind(`[data-app-${module.type}-fancybox="${module.type}-${module.moduleId}"]`, module.options);        
    }
}
