using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(T obj)
        {
            try
            {
                sqlContext.Set<T>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return sqlContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return sqlContext.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            try
            {
                sqlContext.Set<T>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}