using Aplikacija.Core.Custom_Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Core
{
    public class PolicyViewModel
    {
        #region policy_data
        public int PolicyID { get; set; }
        public string Serial { get; set; }

        [Required(ErrorMessage = "Внесете дата")]
        [DisplayName("Од Дата")]
        [DataType(DataType.Date)]
        //[Range(typeof(DateTime), "1/1/2020", "1/1/2021", ErrorMessage = "Погрешен датум")]
        public DateTime FromDate { get; set; }

        [Required(ErrorMessage = "Внесете дата")]
        [DisplayName("До Дата")]
        [DataType(DataType.Date)]
       
        public DateTime ToDate { get; set; }

        [DisplayName("Дата на продажба")]
        [DataType(DataType.Date)]
        public DateTime DateSale { get; set; }

        [Required(ErrorMessage = "Одберете пакет")]
        [DisplayName("Пакет:")]
        public Package Package { get; set; }//dropdown lista

        [Required(ErrorMessage = "Одберете франшиза")]
        [DisplayName("Франшиза")]
        public Franshiza Franshiza { get; set; }//dropdown lista

        public decimal Premium { get; set; }

        [DisplayName("ДДВ:")]
        public decimal DDV { get; set; }

        public decimal Premiumtotal { get; set; }

        public decimal SumOsig { get; set; }
        public Valute Valute { get; set; }//dropdown lista
        #endregion

        #region contractor_data
        public Guid ContractorID { get; set; }
        [Required(ErrorMessage = "Внесете го името на договарачот")]
        [DisplayName("Име на договарач")]
        public string ContractorName { get; set; }
        [Required(ErrorMessage = "Внесете го презимето на договарачот")]
        [DisplayName("Презиме на договарач")]
        public string ContractorSurname { get; set; }
        //[Required(ErrorMessage = "Внесете те го матичниот број на договарачот")]
        [DisplayName("Матичен број на договарач")]
        public string ContractorEMBG { get; set; }
        //[Required(ErrorMessage = "Внесете го регистарскиот број-правно лице")]
        [DisplayName("Регистарски број-правно лице")]
        public string ContractorRegnumber { get; set; }
        [Required(ErrorMessage = "Внесете те го мобилниот телефон на договарачот")]
        [DisplayName("Моб.Тел. на договарач")]
        public string ContractorPhone { get; set; }
        [Required(ErrorMessage = "Внесете факс број на договарачот")]
        [DisplayName("Факс на договарач")]
        public string ContractorFax { get; set; }
        [Required(ErrorMessage = "Одберете, физичко или правно лице")]
        [DisplayName("Лице")]
        public int ContractorTipkindId { get; set; }
        [DisplayName("Лице: ")]
        public Tipkind ContractorTipkind { get; set; }//dropdown lista
        #endregion

        #region insured_data
        public Guid InsuredID { get; set; }
        [Required(ErrorMessage = "Внесете име на осигуреник")]
        [DisplayName("Име на осигуреник")]
        public string InsuredName { get; set; }
        [Required(ErrorMessage = "Внесете презиме на осигуреник")]
        [DisplayName("Презиме на осигуреник")]
        public string InsuredSurname { get; set; }
        //[Required(ErrorMessage = "Внесете матичен број на осигуреник")]
        [DisplayName("Матичен број на осигуреник")]
        public string InsuredEMBG { get; set; }
        [DisplayName("Регистарски број-правно лице")]
        public string InsuredRegnumber { get; set; }
        [Required(ErrorMessage = "Внесете го мобилниот телефон на осигуреникот")]
        [DisplayName("Моб.Тел. на осигуреник")]
        public string InsuredPhone { get; set; }
        [Required(ErrorMessage = "Внесете го факсот на осигуреникот")]
        [DisplayName("Факс на осигуреник")]
        public string InsuredFax { get; set; }
        [DisplayName("Лице: ")]
        public Tipkind InsuredTipkind { get; set; }//dropdown lista

        public DateTime InsuredBirthDate { get; set; }
        #endregion

        #region beneficiary_data
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Внесете го името")]
        [DisplayName("Име")]
        public string BeneficiaryName { get; set; }
        [Required(ErrorMessage = "Внесете го презимето")]
        [DisplayName("Презиме")]
        public string BeneficiarySurname { get; set; }
        public string BeneficiaryEMBG { get; set; }
        [DisplayName("Регистарски број-правно лице")]
        public string BeneficiaryRegnumber { get; set; }
        [Required(ErrorMessage = "Внесете го мобилниот телефон")]
        [DisplayName("Мобилен телефон")]
        public string BeneficiaryPhone { get; set; }
        [Required(ErrorMessage = "Внесете факс")]
        [DisplayName("Факс")]
        public string BeneficiaryFax { get; set; }
        [Required(ErrorMessage = "Одберете физичко/правно лице")]
        [DisplayName("Физичко или правно лице")]
        public Tipkind BeneficiaryTipkind { get; set; }//dropdown lista
        #endregion

        #region vehicle_data
        public Guid VehicleID { get; set; }
        [Required(ErrorMessage = "Внесете тип на возило")]
        [DisplayName("Тип на возило")]
        public string VehicleTypeVehicle { get; set; }
        [Required(ErrorMessage = "Внесете регистрација")]
        [DisplayName("Регистрација")]
        public string VehicleRegnumber { get; set; }
        [Required(ErrorMessage = "Внесете број на шасија")]
        [DisplayName("Број на шасија")]
        public string VehicleChassis { get; set; }
        [Required(ErrorMessage = "Внесете го број на мотор")]
        [DisplayName("Број на мотор")]
        public string VehicleMotorNum { get; set; }
        [Required(ErrorMessage = "Внесете го бројот на коњските сили")]
        [DisplayName("Број на коњнски сили")]
        public decimal VehiclePower { get; set; }
        [Required(ErrorMessage = "Внесете го капацитетот на моторот")]
        [DisplayName("Капацитет на мотор")]
        public decimal VehicleCapacity { get; set; }
        [Required(ErrorMessage = "Внесете ја бојата")]
        [DisplayName("Боја")]
        public string VehicleColor { get; set; }
        [Required(ErrorMessage = "Внесете го бројот на седишта")]
        [DisplayName("Седишта")]
        public int VehicleSeetsNum { get; set; }

        #endregion
    }
}
