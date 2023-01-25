using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL.Repositories
{
    public interface IService<T>where T : class
    {
        IEnumerable<T> FetchAll();
        T Fetch(int id);
       
    }
}
