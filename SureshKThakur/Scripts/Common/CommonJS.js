function GetStateList() {
    $.ajax({
        url: "../../Home/GetStateList",
        type: 'POST',
        success: function (response) {
            if (response) {
                for (const element of response) {
                    $("#ddlState").append($("<option></option>").val(element.ItemId).html(element.ItemName));
                }
            }
        },
        error: function (error) {
            console.log(error)
        }
    });
}

function GetDistrictListByStateId(StateId) {
    debugger;
    $.ajax({
        url: "../../Home/GetDistrictListByStateId",
        type: 'POST',
        data: { StateId: StateId },
        async: false,
        success: function (response) {
            if (response) {
                $("#ddlDistrict").empty();
                for (const element of response) {
                    $("#ddlDistrict").append($("<option></option>").val(element.ItemId).html(element.ItemName));
                }
            }
        },
        error: function (error) {
            console.log(error)
        }
    });
}

function GetStaffEduction() {
    $.ajax({
        url: "../../Staff/GetStaffEduction",
        type: 'POST',
        success: function (response) {
            if (response) {
                for (const element of response) {
                    $("#ddlStaffEduction").append($("<option></option>").val(element.ItemId).html(element.ItemName));
                }
            }
        },
        error: function (error) {
            console.log(error)
        }
    });
}
function GetStaffRole() {
    $.ajax({
        url: "../../Staff/GetStaffRole",
        type: 'POST',
        success: function (response) {
            if (response) {
                for (const element of response) {
                    $("#ddlStaffRole").append($("<option></option>").val(element.ItemId).html(element.ItemName));
                }
            }
        },
        error: function (error) {
            console.log(error)
        }
    });
}