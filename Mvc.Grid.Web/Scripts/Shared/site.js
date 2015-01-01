$(document).ready(function () {
    $('.main-menu').on('click', 'a', function (e) {
        if ($(this).hasClass('dropdown-toggle') || $(this).closest('li').find('ul').length == 0) {
            var current = $(this).next();
            if (current.is(':visible')) {
                $(this).closest('li.dropdown').find("ul.dropdown-menu").slideUp('fast');
            } else {
                current.slideDown('fast');
            }
        }
    });
});
