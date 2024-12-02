
export function showEncryptedMails() {
  /* mailencrypting */
  setTimeout(function () {
    let mailElement = document.querySelectorAll('[data-madr1]:not(.madr-done)');

    mailElement.forEach((mail: Element, index) => {
      const maddr = mail.getAttribute('data-madr1') + '@' + mail.getAttribute('data-madr2') + '.' + mail.getAttribute('data-madr3');
      const linktext = mail.getAttribute('data-linktext') ? mail.getAttribute('data-linktext') : maddr;

      const a = document.createElement('a')
      a.setAttribute('href', `mailto:${maddr}`)
      a.innerHTML = linktext || '';
      
      if (mail.parentElement) {
        mail.parentElement.appendChild(a);
      }
      mail.classList.add('madr-done');      
      (mail as HTMLElement).style.display = 'none';
   });

  }, 500);
}