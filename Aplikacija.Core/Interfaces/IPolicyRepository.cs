using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public interface IPolicyRepository
    {
        void Add(Policy obj);
        void Edit(Policy obj);
        void Remove(int ID);
        IEnumerable GetPolicy();
        Policy FindById(int Id);
    }
}
