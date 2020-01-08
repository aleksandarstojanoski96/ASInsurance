using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Core.Interfaces
{
    public interface IGetDatabase
    {
        List<Type> GetAll();
    }
}
