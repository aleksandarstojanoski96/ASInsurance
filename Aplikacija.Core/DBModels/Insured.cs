using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Insured
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMBG { get;set;}
        public string Regnumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Tipkind { get; set; }

        public Policy Policy { get; set; }
    }
}
