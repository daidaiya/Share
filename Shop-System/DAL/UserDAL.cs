using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;


namespace Shop_System.DAL
{
    public class UserDAL<T> where T : class, new()
    {
        DbContext Db = new DbContextFactory().CreateDbContext();
        /// <summary>C:\Users\daisy\source\repos\Shop-System\Shop-System\DAL\UserDAL.cs
        /// query
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return Db.Set<T>().Where<T>(whereLambda);
        }
    }
}