/*
Name: 			Business Consulting 2
Written by: 	Okler Themes - (http://www.okler.net)
Theme Version:	8.0.0
*/

(function( $ ) {

	'use strict';
	
	// Revolution Slider
	$('#revolutionSlider').revolution({
		sliderType: 'standard',
		sliderLayout: 'auto',
		delay: 9000,
		responsiveLevels: [4096,1200,992,768],
		gridwidth:[1100,920,680,500],
		gridheight: [991,991,991,750],
		disableProgressBar: 'on',
		spinner: 'spinner3',
		parallax:{
			type:"on",
			levels:[20,40,60,80,100],
			origo:"enterpoint",
			speed:400,
			bgparallax:"on",
			disable_onmobile:"off"
		},
		navigation: { 
			arrows: {
				enable: true,
			},
			bullets: { 
				enable: false,
			}
		}
	});

	// Accordion
	$("[data-parent='#accordionServices']").on("click", function() {
		var trigger = $(this);
		$("#accordionServices .collapse.show").each(function() {
			if (trigger.attr("href") != ("#" + $(this).attr("id"))) {
				$(this).removeClass("show");
			}
		});
	});
	
}).apply( this, [ jQuery ]);