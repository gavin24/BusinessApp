﻿using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Implementation
{
   public interface ILocationRestRepository : IBaseRestRepository<Location>
    {
        Location GetLocationByCustomerId(long customerId);
    }
}
