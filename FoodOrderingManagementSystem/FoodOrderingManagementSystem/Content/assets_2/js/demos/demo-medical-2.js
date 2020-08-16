/*
Name: 			Medical 2
Written by: 	Okler Themes - (http://www.okler.net)
Theme Version:	8.0.0
*/

(function( $ ) {

	'use strict';
	
    $('#revolutionSlider').revolution({
        sliderType: 'standard',
        sliderLayout: 'auto',
		delay: 9000,
        responsiveLevels: [4096,1200,992,768],
        gridwidth:[1100,920,680,500],
		gridheight: [991,991,991,650],
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
                enable: false,
            },
            bullets: { 
                enable: true,
                hide_under: 768, 
                style: 'uranus', 
                tmp: '<span class="tp-bullet-inner bg-color-quaternary"></span>',
				h_align:"center",
				v_align:"bottom",
				h_offset:0,
				v_offset:240,
				space:12,
            }
        }
    })
	
}).apply( this, [ jQuery ]);