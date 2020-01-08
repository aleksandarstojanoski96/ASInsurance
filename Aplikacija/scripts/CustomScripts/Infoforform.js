$(document).ready(function () {

    $("#voziloklik").click(function () {

        $("#ulvozilo").show();
        $("#uldogovaracosigurenik").hide();
        $("#ulpokritie").hide();
    })

    $("#dogovaracklik").click(function () {
        
        $("#ulvozilo").hide();
        $("#uldogovaracosigurenik").show();
        $("#ulpokritie").hide();
    })

     $("#osigurenikklik").click(function () {
        
         $("#ulvozilo").hide();
         $("#uldogovaracosigurenik").show();
         $("#ulpokritie").hide();
     })

     $("#pokritieklik").click(function () {

         $("#ulvozilo").hide();
         $("#uldogovaracosigurenik").hide();
         $("#ulpokritie").show();
     })

});