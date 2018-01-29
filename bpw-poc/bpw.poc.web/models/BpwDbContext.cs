using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpw.poc.web.models
{
    public class BpwDbContext : DbContext
    {
        
        public BpwDbContext(DbContextOptions options) : base(options)
        {
        }

        
       public DbSet<book> book { get; set; }
    }
}
