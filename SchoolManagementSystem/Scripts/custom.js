$(document).ready(function () {
    //$(".chosen").chosen({ max_selected_options: 5 });
    //getItems('countyDropDown', 'constituencyDropDown', '/SchoolDetails/getConstituencies');
    $('.select2').select2({
        allowClear: true
    });

    loadTextBoxFromSelect('PostalName', 'postalCodeText');
    //var selectedCounty = $('#countyDropDown').val();
    //var selectedConstituency = $('#constituencyDropDown').val();
    //var selectedWard = $('#wardDropDown').val();
    
    //$("#countyDropDown").val(selectedCounty).trigger("change");
    //$("#constituencyDropDown").val(selectedConstituency).trigger("change");
    //$("#wardDropDown").val(selectedWard).trigger("change");

    //$("#countyDropDown").val(selectedCounty);
    //$("#constituencyDropDown").val(selectedConstituency);
    //$("#wardDropDown").val(selectedWard);
    
});

function getItems(dropDownId, toUpdateDropDownId, updatingUrl) {
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
           // $("#" + toUpdateDropDownId).append('<option></option>');
            $.each($.parseJSON(result), function (i, item) {
                $("#" + toUpdateDropDownId).append
                ($('<option></option>').val(item.Id).html(item.Name))
            })
        },
        error: function (request, status, error) {
            //alert(request.responseText);
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

function loadTextBoxFromSelect(selectId, textBoxId)
{
    var selectText = $('#' + selectId +" option:selected").text();
    var selectValue = $('#' + selectId).val();
    $('#' + textBoxId).val('');
    $('#' + textBoxId).val(selectValue);
}

function bootboxConfirm(confirmMessage)
{
   bootbox.confirm(confirmMessage, function (result) {
        return result;
    })
}

function clearSelectedData(selectId)
{
    $('#' + selectId).val('');
}

function clearTextData(textId)
{
    $('#' + textId).val('');
}