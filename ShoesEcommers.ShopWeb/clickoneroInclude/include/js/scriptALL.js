// @codekit-prepend  "js/scripts/isMobile.js";
// @codekit-prepend  "js/scripts/acordeonFilter.js";
// @codekit-prepend  "js/scripts/carouselSwiper.js";
// @codekit-prepend  "js/scripts/carruselVerticalSwiper.js";
// @codekit-prepend  "js/scripts/changeOffer.js";
// @codekit-prepend  "js/scripts/chooseDate.js";
// @codekit-prepend  "js/scripts/customCheckbox.js";
// @codekit-prepend  "js/scripts/customRadio.js";
// @codekit-prepend  "js/scripts/customSelect.js";
// @codekit-prepend  "js/scripts/customSlider3-ck.js";
// @codekit-prepend  "js/scripts/datePicker.js";
// @codekit-prepend  "js/scripts/hideLogo.js";
// @codekit-prepend  "js/scripts/imageError.js";
// @codekit-prepend  "js/scripts/imageProduct.js";
// @codekit-prepend  "js/scripts/fancyBox.js";
// @codekit-prepend  "js/scripts/point.js";
// @codekit-prepend  "js/scripts/openFolderWidget.js";
// @codekit-prepend  "js/scripts/preloader.js";
// @codekit-prepend  "js/scripts/showDiv.js";
// @codekit-prepend  "js/scripts/scrollpane.js";
// @codekit-prepend  "js/scripts/resizeFilter.js";
// @codekit-prepend  "js/scripts/toolTip.js";

// @codekit-prepend  "js/scripts/WB-filterToggle.js";

// ++++++++++++++++++++++++++++++++++++++++++++
//      OVERME: Retrasa la muestra del menú
// ++++++++++++++++++++++++++++++++++++++++++++

	jQuery.fn.overMe = function(options){
		var defaults = $.extend({
			div: '.subMenu',
			clase: 'menuOverMe'
		}, options);
		return this.each(function(){
			var $this = $(this),
				timeoutVar;
			$this.on({
				mouseover: function(){
					timeoutVar = setTimeout(function () {
						$this.addClass(defaults.clase);
					}, 500);
				},
				mouseleave: function(){
					clearTimeout(timeoutVar);
					$this.removeClass(defaults.clase);
				}
			});
		});
	};



// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//     Funciones que se deben cargar al finalizar el DOM en todas las páginas
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

	function DocumentReady () {
		isMobile();
		$('.clickoneroPreloader').preloader();
		$('.clickoneroSelect').customSelect();
		$('.slider-input').customSlider({});
		$('.clickoneroFancybox').fancyBox();
		// $('img').imageError({ src: 'clickoneroInclude/images/misc/noImage.jpg'});
		$('.menuli-div').overMe();
		$('.clickoneroMainHeader').openFolderWidget();
		$('.clickoneroToolTip').toolTip({clase: 'clickoneroTool-Tip'});
		$('.ck-banner-campaing').each(function(){
			if($(this).find('p').text().length > 20){
				$(this).toolTip({clase: 'clickoneroTool-Tip', tipHTML: false});
			}
		});
	}

	