using A02.Envanter.Entity;
using A03.Envanter.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL
{
    public class MakinaManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<Makina> GetAll()
        {
            return context.Makinalar.ToList();
        }

        public int Add(Makina makina)
        {
            context.Makinalar.Add(makina);
            return context.SaveChanges();
        }
        public int Update(Makina makina)
        {
            context.Makinalar.AddOrUpdate(makina);
            return context.SaveChanges();
        }

        public int Delete(Makina makina)
        {
            context.Makinalar.Remove(makina);
            return context.SaveChanges();
        }
        public Makina Get(int id)
        {
            return context.Makinalar.Find(id);
        }
    }
}
