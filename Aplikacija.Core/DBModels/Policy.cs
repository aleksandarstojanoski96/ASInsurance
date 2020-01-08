using Aplikacija.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Policy
    {
        public int ID { get; set; }
        public string Serial { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime DateSale { get; set; }
        public string Package { get; set; }
        public string Franshiza { get; set; }
        public decimal Premium { get; set; }
        public decimal DDV { get;set;}
        public decimal Premiumtotal { get; set; }
        public decimal SumOsig { get; set; }
        public string Valute { get; set; }
        public DateTime Moment { get; set; }


        public List<Contractor> Contractor { get; set; }
        public List<Insured> Insurers { get; set; }
        public List<Beneficiary> Beneficiaries { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
