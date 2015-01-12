$(document).ready(function () {
    $('.content-toggle').on('click', function (e) {
        $(this).toggleClass('open');
        $(this).parents('.widget:first').find('.widget-content').slideToggle();
    });
});

// NiceScroll binding
(function () {
    $('body').niceScroll({
        cursoropacitymin: 0.5,
        cursorborderradius: 0,
        cursorborder: "none",
        cursorwidth : 10,
        zindex: 1000
    });
}());