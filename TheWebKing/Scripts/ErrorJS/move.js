jQuery(document).ready(function () {
    $('#sky').plaxify({ "xRange": 10, "yRange": 0 })
    $('#mountains').plaxify({ "xRange": 25, "yRange": 2 })
    $('#trees').plaxify({ "xRange": 40, "yRange": 8 })
    $('#rabbit').plaxify({ "xRange": 55, "yRange": 14 })
    $('#hill').plaxify({ "xRange": 90, "yRange": 40 })
    $('#sign').plaxify({ "xRange": 185, "yRange": 80 })
    $('#content').plaxify({ "xRange": 55, "yRange": 14 })
    $.plax.enable();
    $('.downloadlink').click(function (e) {
        e.preventDefault();
        $('.download').slideDown();
    });
});