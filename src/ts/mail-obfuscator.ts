
export function showEncryptedMails() {
  /* mailencrypting */
  setTimeout(function () {
    let mailElement = document.querySelectorAll('[data-madr1]:not(.madr-done)');

    mailElement.forEach((mail: HTMLElement, index) => {
      const maddr = mail.getAttribute('data-madr1') + '@' + mail.getAttribute('data-madr2') + '.' + mail.getAttribute('data-madr3');
      const linktext = mail.getAttribute('data-linktext') ? mail.getAttribute('data-linktext') : maddr;
      mail.after('<a href="mailto:' + maddr + '">' + linktext + '</a> ')
      mail.classList.add('madr-done');      
      mail.style.display = 'none';
   });

  }, 500);
}