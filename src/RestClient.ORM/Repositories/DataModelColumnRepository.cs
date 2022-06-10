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
    public class DataModelColumnRepository : BaseRepository<DataModelColumn>
    {
        private ApplicationDbContext _context;
        public DataModelColumnRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override Task<DataModelColumn> GetById(Guid id)
        {
            return _context.DataModelColumns
                .Include(dmc => dmc.DataModel)
                .Include(dmc => dmc.DataType)
                .SingleOrDefaultAsync(dmc => dmc.Id == id);
        }
    }
}
