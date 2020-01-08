using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IBeneficiaryRepository
    {
        void Add(Beneficiary obj);
        void Edit(Beneficiary obj);
        void Remove(int ID);
        IEnumerable GetBeneficiary();
        Beneficiary FindById(int Id);
    }
}
