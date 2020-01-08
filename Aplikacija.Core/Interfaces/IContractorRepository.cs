using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IContractorRepository
    {
        void Add(Contractor obj);
        void Edit(Contractor obj);
        void Remove(int ID);
        IEnumerable GetContractor();
        Contractor FindById(int Id);
    }
}
