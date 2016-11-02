(function(){
	var loadFiles = function (path) {
		var escribe = '<script src="' + path + 'idangerous.swiper.min.js"><\/script>\n';
		escribe += '<script src="' + path + 'idangerous.swiper.scrollbar-2.1.js"><\/script>\n';
		document.write(escribe);
	};
	loadFiles("clickoneroInclude/include/js/libs/swiper/");
})();