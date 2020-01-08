function myFunction() {
    var checkBox = document.getElementById("myCheck");

        var src = document.getElementById("ContractorName"),
            dst = document.getElementById("InsuredName");

        var src1 = document.getElementById("ContractorSurname"),
        dst1 = document.getElementById("InsuredSurname");

        var src2 = document.getElementById("ContractorEMBG"),
            dst2 = document.getElementById("InsuredEMBG");

        var src3 = document.getElementById("ContractorRegnumber"),
            dst3 = document.getElementById("InsuredRegnumber");

        var src4 = document.getElementById("ContractorPhone"),
            dst4 = document.getElementById("InsuredPhone");

        var src5 = document.getElementById("ContractorFax"),
            dst5 = document.getElementById("InsuredFax");
        if (checkBox.checked == true) {
            dst.value = src.value;
            dst1.value = src1.value;
            dst2.value = src2.value;
            dst3.value = src3.value;
            dst4.value = src4.value;
            dst5.value = src5.value;
     //       src.addEventListener('input', function () {
     //           dst.value = src.value;
     //       }
     //);

        //    src1.addEventListener('input', function () {
        //        dst1.value = src1.value;
        //    }
        //   );
        //    src2.addEventListener('input', function () {
        //        dst2.value = src2.value;
        //    }
        //);
        //    src3.addEventListener('input', function () {
        //        dst3.value = src3.value;
        //    }
        //);
        //    src4.addEventListener('input', function () {
        //        dst4.value = src4.value;
        //    }
        //);
        //    src5.addEventListener('input', function () {
        //        dst5.value = src5.value;
        //    }
        //);
        }
};