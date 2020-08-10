using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BacFitGym.PersistenciaDatos.Repository
{
    public class Repository<FitGymDb> : IRepository where FitGymDb : DbContext
    {
        private readonly FitGymDb _context;

        public Repository(FitGymDb context)
        {
            _context = context;
        }
        public async Task Post<T>(T t) where T : class
        {
            this._context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<T>>> GetAll<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById<T>(Expression<Func<T, bool>> t) where T: class
        {
            return await _context.Set<T>().Where(t).FirstOrDefaultAsync();
        }
    }
}
