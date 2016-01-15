$(function () {
    $('.nav-list').on('click', 'li', function () {
        var url = $(this).find("#Url").val();
        $('.nav-list li.active').removeClass('active');
        $(this).addClass('active');        

        $.get(url, function (data) { $("#maincontainer").html(data) });

    });

});