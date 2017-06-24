$(document).ready(function () {
    $(".chosen").chosen();
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