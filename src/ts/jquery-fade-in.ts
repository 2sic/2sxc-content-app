/** 
 * In case jQuery slim is loaded, fadeIn is missing and would cause errors
 * So we check for that and just put an empty function there
 */
export function monkeyPatchjQueryFade() {
  const jQueryProto = ($() as any).__proto__;
  if(!jQueryProto.fadeIn)
    jQueryProto.fadeIn = function () { /* do nothing */ }
}