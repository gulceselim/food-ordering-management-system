window.scwProgressPlugin = window.scwProgressPlugin || {};

window.SEMICOLON_progressInit = function( $progressEl ){

	$progressEl = $progressEl.filter(':not(.customjs)');

	if( $progressEl.length < 1 ){
		return true;
	}

	$progressEl.each(function(){
		let element	= $(this),
			elBar	= element.parent('li'),
			elValue	= elBar.attr('data-percent');

		if( $('body').hasClass('device-xl') || $('body').hasClass('device-lg') ){
			let observer = new IntersectionObserver((entries, observer) => {
				entries.forEach((entry) => {
					if (entry.isIntersecting) {
						if (!elBar.hasClass('skills-animated')) {
							SEMICOLON.widget.counter({
								el: element.find('.counter-instant')
							});
							elBar.find('.progress').css({width: elValue + "%"}).addClass('skills-animated');
						}
						observer.unobserve( entry.target );
					}
				});
			}, {rootMargin: '-50px'});
			observer.observe( element[0] );
		} else {
			SEMICOLON.widget.counter( element.find('.counter-instant')[0] );
			elBar.find('.progress').css({width: elValue + "%"});
		}
	});

};
