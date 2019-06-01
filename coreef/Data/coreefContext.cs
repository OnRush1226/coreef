using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreef.Models
{
    public class coreefContext : DbContext
    {
        public coreefContext (DbContextOptions<coreefContext> options)
            : base(options)
        {
        }

        public DbSet<coreef.Models.Phone> Phone { get; set; }
    }
}
