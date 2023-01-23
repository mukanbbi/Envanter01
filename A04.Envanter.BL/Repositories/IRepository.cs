using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A04.Envanter.BL.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();//tüm kayıtları getir. SELECT* FROM URUNLER
        List<T> GetAll(Expression<Func<T, bool>> expression);//WHERE LI SORGU ÇEKMEYE YARAR
        IQueryable<T> GetAllByInclude(string table);
        IQueryable<T> GetAllByInclude2(string table, string table2);
        IQueryable<T> GetAllByInclude4(string table, string table2, string table3, string table4);//Joinli sorgularda kullanabiliriz.
        T Find(int id);
        T Get(Expression<Func<T, bool>> expression); //Bu gelen sorguya göre1 kayıt getir birden fazla alan döndürür.
        int Add(T entity);
        int Update(T entity);

        int Delete(int id);
    }
}
