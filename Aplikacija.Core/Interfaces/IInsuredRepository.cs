using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public interface IInsuredRepository
    {
        void Add(Insured obj);
        void Edit(Insured obj);
        void Remove(int ID);
        IEnumerable GetInsured();
        Insured FindById(int Id);
    }
}
