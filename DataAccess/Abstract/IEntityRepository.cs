using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //generic constraint
    //class: reference type
    //IEntity: it can be IEntity or an object that has been implemented from IEntity
    //new(): it should be new able (It cannot be IEntity interface)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //you can use expressions like p=>p.CategoryId==2
        //filter=null means you don't have to give filter parameter. So you can get all data without filter 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
