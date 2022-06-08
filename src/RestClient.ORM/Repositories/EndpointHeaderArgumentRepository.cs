﻿using RestClient.Orm;
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
        public EndpointHeaderArgumentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
