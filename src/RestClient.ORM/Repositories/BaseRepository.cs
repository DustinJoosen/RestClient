using Microsoft.EntityFrameworkCore;
using RestClient.Infra;
using RestClient.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IIdentifiable
    {
        private ApplicationDbContext _context;
        private DbSet<T> _entry;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entry = _context.Set<T>();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _entry.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _entry.SingleOrDefaultAsync(t => t.Id == id);
        }

        public virtual async Task<T> Create(T model)
        {
            model.Id = Guid.NewGuid();

            _entry.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public virtual async Task<T> Update(Guid id, T model)
        {
            if (id != model.Id)
            {
                throw new Exception("The guid of the model and the given guid do not match");
            }

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return model;
        }

        public virtual async Task<T> Delete(Guid id)
        {
            var model = await GetById(id);
            return await Delete(model);
        }

        public virtual async Task<T> Delete(T model)
        {
            _entry.Remove(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public virtual void Detach(T model)
        {
            if (model == null)
            {
                return;
            }

            _context.Entry<T>(model).State = EntityState.Detached;
        }

    }
}
