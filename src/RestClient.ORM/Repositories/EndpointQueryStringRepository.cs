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
    public class EndpointQueryStringRepository : BaseRepository<EndpointQueryString>
    {
        private ApplicationDbContext _context;
        public EndpointQueryStringRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<EndpointQueryString> GetById(Guid id)
        {
            var endpointQueryString = await _context.EndpointQueryStrings
                .Include(e => e.Endpoint)
                .SingleOrDefaultAsync(e => e.Id == id);

            base.Detach(endpointQueryString);
            return endpointQueryString;
        }
    }
}
