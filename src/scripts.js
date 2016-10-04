$(document).ready(function(){
	/* mailencrypting */
	setTimeout(function(){
		$('[data-madr1]:visible').each(function(){
			$this = $(this);
			maddr = $this.attr('data-madr1') + '@' + $this.attr('data-madr2') + '.' + $this.attr('data-madr3');
			$this.after( '<a href="mailto:'+maddr+'">'+maddr+'</a>' );
			$this.hide();
		});
	}, 500);

	/* Fancybox */
	if(jQuery().fancybox){
		$(".fancybox").fancybox({
			parent: "form:first",
			padding: 1
		});
	}
});