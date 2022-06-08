﻿using RestClient.Orm;
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
        public ApiRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
