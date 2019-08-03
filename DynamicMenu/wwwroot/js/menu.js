$(document).ready(function () {
    if ($('#dynNav').attr('href') === null) {
        $("#dynNav").removeClass("dropdown-toggle");
        $("#dynNav").removeAttr("dropdown");
    }
    //alert("window loaded");
});