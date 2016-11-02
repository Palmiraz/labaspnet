(function(){
	var loadFiles = function (path) {
		var escribe = '<script src="' + path + 'jquery.fancybox.js?v=2.1.5"><\/script>\n';
		escribe += '<link rel="stylesheet" href="' + path + 'jquery.fancybox.css?v=2.1.5">\n';
		document.write(escribe);
	};
	loadFiles("clickoneroInclude/include/js/libs/fancybox/");
})();