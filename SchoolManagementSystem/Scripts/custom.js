$(document).ready(function () {
    $(".chosen").chosen({ max_selected_options: 5 });
    //getItems('countyDropDown', 'constituencyDropDown', '/SchoolDetails/getConstituencies');

});

function getItems(dropDownId, toUpdateDropDownId, updatingUrl, updateValueId) {
    var itemId = $("#" + dropDownId).val();
    $.ajax
    ({
        url: updatingUrl,
        type: 'POST',
        datatype: 'application/json',
        contentType: 'application/json',
        data: JSON.stringify({
            itemId: +itemId
        }),
        success: function (result) {
            $("#" + toUpdateDropDownId).html("");
            $("#" + toUpdateDropDownId).append('<option></option>');
            $.each($.parseJSON(result), function (i, item) {
                $("#" + toUpdateDropDownId).append
                ($('<option></option>').val(item.Id).html(item.Name))
            })
            $("#" + toUpdateDropDownId).chosen().trigger("chosen:updated");
        },
        error: function (request, status, error) {
            alert(request.responseText);
        },
    });

}

function readURL(input) {
    if (input.files && input.files[0]) {
       
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#schLogo').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#schLogoId").change(function () {
    
    readURL(this);
});