using A02.Envanter.Entity;
using A04.Envanter.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL
{
    public class RolService : Repository<Rol>, IService<Rol>
    {
        public Rol Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rol> FetchAll(Expression<Func<Rol, bool>> predicate)
        {
            var source = base.GetAll(predicate);
            return (from item in source
                    select new Rol
                    {
                        Id = item.Id,
                        Adi = item.Adi
                    }
                    ).OrderBy(model => model.Id);
        }

        public IEnumerable<Rol> FetchAll()
        {
            throw new NotImplementedException();
        }
    }
}
