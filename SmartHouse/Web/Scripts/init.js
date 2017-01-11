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
        url: 'Switch/ToggleSwitch/' + data
    });
}

function smoothSliderSetValue(data) {
    $.ajax({
        url: 'SmoothSlider/SetValue/' + data + '?value=' + $('#' + data).val()
    });
}

function stepSliderIncrease(data) {
    $.ajax({
        url: 'StepSlider/IncreaseValue/' + data
    }).done(function () {
        var input = $('#' + data);
        input.val(parseInt(input.val()) + parseInt(input.attr('step')));
    });
}

function stepSliderReduce(data) {
    $.ajax({
        url: 'StepSlider/ReduceValue/' + data
    }).done(function () {
        var input = $('#' + data);
        input.val(parseInt(input.val()) - parseInt(input.attr('step')));
    });
}