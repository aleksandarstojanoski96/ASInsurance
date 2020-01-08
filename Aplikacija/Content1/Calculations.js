function Presmetka() {
    var VehicleCapacity = document.getElementById("VehicleCapacity");
    var Package = document.getElementById("Package");
    var Franshiza = document.getElementById("Franshiza");
    var Datefrom = document.getElementById("FromDate");
    var Dateto = document.getElementById("ToDate");

    VehicleCapacity.addEventListener('input', function () {
        document.getElementById("tt").innerHTML = VehicleCapacity.value;
    });
}
