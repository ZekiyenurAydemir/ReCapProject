using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    //Generic yapı oluşturduk
    //Temel Crud işlemleri
    public interface IEntityRepository<T> where T : class, IEntitiy, new()
    {
        //****************ÖNEMLİ 
        //Filtreleme için kullanılır
        //null olması filtre vermeden getirmek için
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Tek bi kayıtın detayını görüntülemek gibi kullanabiliriz /Bir filtre zorunludur
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
