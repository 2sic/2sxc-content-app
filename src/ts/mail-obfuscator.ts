
export function showEncryptedMails() {
  /* mailencrypting */
  setTimeout(function () {
    $('[data-madr1]').not('.madr-done').each(function () {
      const $this = $(this);
      const maddr = $this.attr('data-madr1') + '@' + $this.attr('data-madr2') + '.' + $this.attr('data-madr3');
      const linktext = $this.attr('data-linktext') ? $this.attr('data-linktext') : maddr;
      $this.after('<a href="mailto:' + maddr + '">' + linktext + '</a> ');
      $this.addClass('madr-done').hide();
    });
  }, 500);
}