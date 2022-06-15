﻿using Pet.BL.Abstract;
using Pet.DAL.Abstract;
using Pet.DAL.Concrete;
using Pet.Entities.Abstract;
using Pet.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pet.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : class, IEntity, new()
    {
        private readonly IRepositoryBase<T> repositoryBase;


        public ManagerBase()
        {
            repositoryBase = new RepositoryBase<T, SqlDbContext>();
        }
        public virtual int Add(T input)
        {
            return repositoryBase.Add(input);
        }

        public virtual int Delete(T input)
        {
            return repositoryBase.Delete(input);
        }

        public virtual T Find(int id)
        {
            return repositoryBase.Find(id);
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return repositoryBase.GetAll(filter);
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
           return repositoryBase.GetAllInclude(filter, include);
        }

        public virtual int Update(T input)
        {
            return repositoryBase.Update(input);
        }
    }
}
