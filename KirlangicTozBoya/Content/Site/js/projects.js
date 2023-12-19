$(document).ready(function () {

    $('#tozboya').click(function () {
        $('#tozboyaicerik').show();
        $('#renkicerik').hide();
        $('#yuzeyicerik').hide();
        $('#kurutmaicerik').hide();
    });

    $('#renk').click(function () {
        $('#tozboyaicerik').hide();
        $('#renkicerik').show();
        $('#yuzeyicerik').hide();
        $('#kurutmaicerik').hide();
    });

    $('#yuzey').click(function () {
        $('#tozboyaicerik').hide();
        $('#renkicerik').hide();
        $('#yuzeyicerik').show();
        $('#kurutmaicerik').hide();
    });

    $('#kurutma').click(function () {
        $('#tozboyaicerik').hide();
        $('#renkicerik').hide();
        $('#yuzeyicerik').hide();
        $('#kurutmaicerik').show();
    });



});

$('.service-catergory li').on('click', function () {

    $('li').removeClass('active');
    $(this).addClass('active');



});


