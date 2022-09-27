using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        
             T GetById(int id);
            IEnumerable<T> GetAll();
            IEnumerable<T> Find(Expression<Func<T, bool>> expression);
            void Add(T entity);
            void AddRange(IEnumerable<T> entities);
            void Remove(T entity);
            void RemoveRange(IEnumerable<T> entities);
        

    }
}
