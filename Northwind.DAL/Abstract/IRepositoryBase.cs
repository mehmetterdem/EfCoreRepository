using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface IRepositoryBase<TEntity> where TEntity : class,new()
    {
        public int add(TEntity entity);
        public int update(TEntity entity);  
        public int delete(TEntity entity);
        List<TEntity> GetAll();
        public TEntity GetById(int id);
        public List<TEntity> FindAll(Expression.Func)


    }
}
