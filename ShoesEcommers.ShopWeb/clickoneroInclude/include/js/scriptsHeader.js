(function(){
    DocumentReady();
    $('.clickoneroService-SVR-carrusel').carouselSwiper({
        optionsSwiper: {
            slideClass: 'clickoneroService-SVR-slide',
            wrapperClass: 'clickoneroService-SVR-wrapper',
            grabCursor: true,
            loop: true,
            useCSS3Transforms: false,
            slidesPerView: 2,
            cssWidthAndHeight: false
        },
        arrowLeft: '.clickoneroPrevCSRV',
        arrowRight: '.clickoneroNextCSRV',
        slidesNum: 5,
        loop: true,
        slideCSS: '.clickoneroService-SVR-slide'
    });
    $('.clickoneroServiceImage-carrusel').carouselSwiper({
        optionsSwiper: {
            slideClass: 'clickoneroServiceImage-slide',
            wrapperClass: 'clickoneroServiceImage-wrapper',
            grabCursor: true,
            loop: true,
            useCSS3Transforms: false,
            slidesPerView: 5,
            cssWidthAndHeight: false,
            watchActiveIndex: true
        },
        arrowLeft: '.clickoneroArrowLeft',
        arrowRight: '.clickoneroArrowRight',
        slidesNum: 5,
        loop: true,
        slideCSS: '.clickoneroServiceImage-slide',
        onClickSlide: function(swiper){
            $(swiper.container).find('.'+swiper.params.slideClass).each(function(){
                $(this).click(function(){
                    $(this).addClass(swiper.params.slideActiveClass).siblings().removeClass(swiper.params.slideActiveClass);
                });
            });
        }
    });
    $('.clickoneroService-options').customCheckbox();
    $('.clickoneroServiceImage').imageProduct({
        container: '.clickoneroServiceImage-img',
        imgs: '.clickoneroServiceImage-slide',
        activeSlide: '.swiper-slide-active',
        zoom: false
    });
    $('.clickoneroService-SVR-divLink').showDiv();
    $('.clickoneroServiceImage-tabs').tabs({
        collapsible: true,
        heightStyle: 'auto'
    });
})();