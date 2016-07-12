// site.js
(function () {


    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        //if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
        //    $icon.removeClass("fa-fa-bars");
        //    $icon.addClass("fa-fa-bars");
        //} else {
        //    $icon.addClass("fa-fa-bars");
        //    $icon.removeClass("fa-fa-bars");
        //}
    });
})();
