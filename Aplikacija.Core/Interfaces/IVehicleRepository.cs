using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVehicleRepository
    {
        void Add(Vehicle obj);
        void Edit(Vehicle obj);
        void Remove(int ID);
        IEnumerable GetVehicle();
        Vehicle FindById(int Id);
    }
}
