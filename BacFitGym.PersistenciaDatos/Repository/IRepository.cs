using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.PersistenciaDatos.Repository
{
    public interface IRepository
    {
        Task Post<T>(T entity) where T : class;
        Task<ActionResult<IEnumerable<T>>> GetAll<T>() where T : class;
        Task<T> GetById<T>(Expression<Func<T, bool>> t) where T : class;
        Task UpdateAsync<T>(T entity, T y) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
