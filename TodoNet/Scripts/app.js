$(document).ready(function () {

    // navigation active items
    $.each($('#nav-header a'), function (i, link) {
        if ($(link).attr('href') == document.location.pathname + document.location.search)
            $(link).closest('li').first().addClass('active');
        
        console.log(link)
    });

    
});