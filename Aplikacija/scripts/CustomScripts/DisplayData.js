$(document).ready(function () {

    $("#submitcliked").click(function () {

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

        var kompakt = "Компакт Пакет";
        var premium = "Премиум Пакет";
        var ekskluziv = "Ексклузив Пакет";
        
        console.log(paket);
        console.log(contractorName);
    });

});