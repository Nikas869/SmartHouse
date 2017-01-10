(function ($) {
    $(function() {
        $('.button-collapse').sideNav();
        $('#modal1').modal();
        $('select').material_select();
    }); // end of document ready
})(jQuery); // end of jQuery name space

function createSuccess(data) {
    if (data.RedirectUrl)
        window.location.href = data.RedirectUrl;
};

function toggleSwitch(data) {
    $.ajax({
        url: "Switch/ToggleSwitch/" + data
    });
}

function smoothSliderSetValue(data) {
    $.ajax({
        url: "SmoothSlider/SetValue/" + data + "?value=" + $("#" + data).val()
    });
}
