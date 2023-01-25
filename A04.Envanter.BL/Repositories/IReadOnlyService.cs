using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL.Repositories
{
   public interface IReadOnlyService<T>where T:class
    {
        IEnumerable<T> FetcAll();
        T Fetch(int id);
    }
}
