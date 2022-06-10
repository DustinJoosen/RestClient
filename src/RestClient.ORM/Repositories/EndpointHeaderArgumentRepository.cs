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
    public class EndpointHeaderArgumentRepository : BaseRepository<EndpointHeaderArgument>
    {
        private ApplicationDbContext _context;
        public EndpointHeaderArgumentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<EndpointHeaderArgument> GetById(Guid id)
        {
            var endpointHeaderArgument = await _context.EndpointHeaderArguments
                .Include(e => e.Endpoint)
                .SingleOrDefaultAsync(e => e.Id == id);

            base.Detach(endpointHeaderArgument);
            return endpointHeaderArgument;
        }
    }
}
