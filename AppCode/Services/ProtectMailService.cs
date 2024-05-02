using System.Text.RegularExpressions;
using ToSic.Razor.Blade;

namespace AppCode.Services
{
  /// <summary>
  /// Simple service to encrypt eMail addresses in the resulting HTML.
  /// To use, must be created using GetService<ProtectMailService>() in your view, as it needs the Kit.
  /// </summary>
  public class ProtectMailService: Custom.Hybrid.CodeTyped
  {
    public IHtmlTag TryToEncrypt(string eMail, string label = default)
    {
      // Check if it's valid, otherwise just return a span containing the original
      var isValid = new Regex("^[^@]+@[^@]+\\.[^\\.]+$").IsMatch(eMail);
      if (!isValid)
        return Kit.HtmlTags.Span(eMail);
      
      // Seems to be valid, let's request the JS to turn-on...
      Kit.Page.TurnOn("window.appContent.showEncryptedMails()");

      // ...and split the mail into it's components
      var nameAndDomain = eMail.Split('@');
      var domainParts = new Regex("\\.([^\\.]+)$").Split(nameAndDomain[1]);
      var mailSpan = Kit.HtmlTags.Span()
        .Attr("data-madr1", nameAndDomain[0])
        .Attr("data-madr2", domainParts[0])
        .Attr("data-madr3", domainParts[1]);
      if (label != default)  
        mailSpan = mailSpan.Attr("data-linktext", label);
      
      return mailSpan;
    }
  }
}