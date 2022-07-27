using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TenderSystem.Core.Entities;

namespace TenderSystem.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()   //Must be a database object
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);   //Linq filter
        T Get(Expression<Func<T, bool>> filter = null); //Linq filter -> to work with every data type or null
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
