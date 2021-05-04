// https://stackoverflow.com/a/28002292/6834738
export function getScript(source: string, callback: any) {
  var script = document.createElement('script');
  var prior = document.getElementsByTagName('script')[0];
  (script as any).async = 1;

  (script as any).onload = (script as any).onreadystatechange = function( _: any, isAbort: any ) {
      if(isAbort || !(script as any).readyState || /loaded|complete/.test((script as any).readyState) ) {
          script.onload = (script as any).onreadystatechange = null;
          script = undefined;

          if(!isAbort && callback) setTimeout(callback, 0);
      }
  };

  script.src = source;
  prior.parentNode.insertBefore(script, prior);
}
