using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public interface IRepository<T>
    {
        List<T> List(); // Listele

        void Insert(T p); // Ekle

        //Buldurma
        T Get(Expression<Func<T, bool>> filter);

        void Delete(T p); // Sil

        void Update(T p); // Güncelle

        List<T> List(Expression<Func<T,bool>> Filter); // Filter ismini biz belirleriz. Arama için kullanılır.


    }
}
