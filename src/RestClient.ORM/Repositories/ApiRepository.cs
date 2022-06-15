using Microsoft.EntityFrameworkCore;
using RestClient.Orm;
using RestClient.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.ORM.Repositories
{
    public class ApiRepository : BaseRepository<Api>
    {
        private ApplicationDbContext _context;
        public ApiRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Api> GetById(Guid id)
        {
            return await _context.Api
                .Include(a => a.Endpoints)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        public override async Task<List<Api>> GetAll()
        {
            return await _context.Api
                .Include(a => a.Endpoints)
                .ToListAsync();
        }
    }
}
