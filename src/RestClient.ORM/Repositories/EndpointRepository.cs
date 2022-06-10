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
    public class EndpointRepository : BaseRepository<Endpoint>
    {
        private ApplicationDbContext _context;
        public EndpointRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Endpoint> GetById(Guid id)
        {
            var endpoint = await _context.Endpoints
                .Include(e => e.InputModel)
                .Include(e => e.OutputModel)
                .Include(e => e.Api)
                .SingleOrDefaultAsync(e => e.Id == id);

            base.Detach(endpoint);
            return endpoint;
        }

        public override async Task<List<Endpoint>> GetAll()
        {
            return await _context.Endpoints
                .Include(e => e.InputModel)
                .Include(e => e.OutputModel)
                .Include(e => e.Api)
                .ToListAsync();
        }

    }
}
