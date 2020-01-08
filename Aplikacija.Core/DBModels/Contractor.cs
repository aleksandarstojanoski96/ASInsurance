using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contractor
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMBG { get; set; }
        public string Regnumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int TipkindId { get;set;}
        public string Tipkind { get; set; }

        public Policy Policy { get; set; }
    }
}
