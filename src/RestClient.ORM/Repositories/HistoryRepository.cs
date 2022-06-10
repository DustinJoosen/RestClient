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
    public class HistoryRepository : BaseRepository<History>
    {
        private ApplicationDbContext _context;
        public HistoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<History> GetById(Guid id)
        {
            var history = await _context.Histories
                .Include(h => h.Endpoint)
                .SingleOrDefaultAsync(h => h.Id == id);

            base.Detach(history);
            return history;
        }
    }
}
