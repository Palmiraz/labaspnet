(function(){
	// var d = document.getElementsByTagName('html')[0];
	// d.classList.add('clickoneroVertical');
	var loadFiles = function (path) {
		var escribe = '<script src="' + path + 'modernizr-2.6.2.js"><\/script>\n';
		escribe += '<script src="' + path + 'jquery-1.8.3.min.js"><\/script>\n';
		escribe += '<script src="' + path + 'jquery.browser.min.js"><\/script>\n';
		escribe += '<script src="' + path + 'jQueryUI1.9.2/jquery-ui-1.9.2.js"><\/script>\n';
		escribe += '<link rel="stylesheet" href="' + path + 'jscrollpane/jquery.jscrollpane.css"\/>\n';
		escribe += '<script src="' + path + 'jscrollpane/jquery.mousewheel.js"><\/script>\n';
		escribe += '<script src="' + path + 'jscrollpane/jquery.jscrollpane.min.js"><\/script>\n';
		escribe += '<script src="' + path + 'swiper/swiper.js"><\/script>\n';
		escribe += '<script src="' + path + 'fancybox/fancybox.js"><\/script>\n';
		escribe += '<script src="' + path + 'zoom/jquery.zoom.js"><\/script>\n';
		// escribe += '<script src="' + path + 'masonry.pkgd.min.js"><\/script>\n';

		document.write(escribe);
	};
	loadFiles("/clickoneroInclude/include/js/libs/");
})();