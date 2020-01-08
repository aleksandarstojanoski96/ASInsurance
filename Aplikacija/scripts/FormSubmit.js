$(document).ready(function () {

    $("#proba").show();

    $("#ContractorTipkind").on('change', function (e) {
        var test = $("#ContractorTipkind").val();
        if (test == 1) {
            $("#proba").show();
            $("#reg_id").hide();
            $("#prezime").show();
        }
        else if (test == 2) {
            $("#proba").hide();
            $("#reg_id").show();
            $("#prezime").hide();
        }
    })

    $("#proba1").show();

    $("#InsuredTipkind").on('change', function (e) {
        var test = $("#InsuredTipkind").val();
        if (test == 1) {
            $("#proba1").show();
            $("#reg_id1").hide();
            $("#prezime1").show();
        }
        else if (test == 2) {
            $("#proba1").hide();
            $("#reg_id1").show();
            $("#prezime1").hide();
        }
    })


    $('.continue').click(function () {
        $('.nav-tabs > .active').next('li').find('a').trigger('click');
    });
    $('.back').click(function () {
        $('.nav-tabs > .active').prev('li').find('a').trigger('click');
    });


    $("#btn_create_policy").click(function () {

        //Vehicle
        var vehicleTypeVehicle = $("#VehicleTypeVehicle").val();
        var vehicleRegnumber = $("#VehicleRegnumber").val();
        var vehicleChassis = $("#VehicleChassis").val();
        var vehicleMotorNum = $("#VehicleMotorNum").val();
        var vehiclePower = $("#VehiclePower").val();
        var vehicleCapacity = $("#VehicleCapacity").val();
        var vehicleColor = $("#VehicleColor").val();
        var vehicleSeetsNum = $("#VehicleSeetsNum").val();

        //Contractor and Insured
        var contractorTipKind = $("#contract_id option:selected").val();
        var insuredTipKind = $("#insured_id option:selected").val();

        var contractorName = $("#ContractorName").val();
        var insuredName = $("#InsuredName").val();

        var contractorSurname = $("#ContractorSurname").val();
        var insuredSurname = $("#InsuredSurname").val();

        var contractorEMBG = $("#ContractorEMBG").val();
        var insuredEMBG = $("#InsuredEMBG").val();

        var contractorRegnumber = $("#ContractorRegnumber").val();
        var insuredRegnumber = $("#InsuredRegnumber").val();

        var contractorPhone = $("#ContractorPhone").val();
        var insuredPhone = $("#InsuredPhone").val();

        var contractorFax = $("#ContractorFax").val();
        var insuredFax = $("#InsuredFax").val();

        //Pokritie
        var paket = $("#package_id option:selected").val();
        var franshiza = $("#franshiza_id option:selected").val();
        var fromDate = $("#FromDate").val();
        var toDate = $("#ToDate").val();



        $.ajax({
            type: "POST",               //HTTP POST Method  
            url: "/Wizard/Create",   // Controller/View
            data: {
                VehicleTypeVehicle: vehicleTypeVehicle,
                VehicleRegnumber: vehicleRegnumber,
                VehicleChassis: vehicleChassis,
                VehicleMotorNum: vehicleMotorNum,
                VehiclePower: vehiclePower,
                VehicleCapacity: vehicleCapacity,
                VehicleColor: vehicleColor,
                VehicleSeetsNum: vehicleSeetsNum,
                ContractorTipKind: contractorTipKind,
                InsuredTipKind: insuredTipKind,
                ContractorName: contractorName,
                InsuredName: insuredName,
                ContractorSurname: contractorSurname,
                InsuredSurname: insuredSurname,
                ContractorEMBG: contractorEMBG,
                InsuredEMBG: insuredEMBG,
                ContractorRegnumber: contractorRegnumber,
                InsuredRegnumber: insuredRegnumber,
                ContractorPhone: contractorPhone,
                InsuredPhone: insuredPhone,
                ContractorFax: contractorFax,
                InsuredFax: insuredFax,
                Package: paket,
                Franshiza: franshiza,
                FromDate: fromDate,
                ToDate: toDate,
            },
            success: function (status) {
                alert("Податоците се успешно зачувани");
                //window.location.reload();
                //$("#roomForm").dialog("close");
            },
            error: function () {
                alert("Грешка во податоците");
                // $("#roomForm").dialog("close");
            }
        });
    });

});
