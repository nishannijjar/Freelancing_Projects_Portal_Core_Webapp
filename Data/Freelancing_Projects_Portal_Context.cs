using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Freelancing_Projects_Portal_Core_Webapp.BussinessLayer;

namespace Freelancing_Projects_Portal_Core_Webapp.Models
{
    // Connects the database layer with the business layer
    public class Freelancing_Projects_Portal_Context : DbContext
    {
        public Freelancing_Projects_Portal_Context (DbContextOptions<Freelancing_Projects_Portal_Context> options)
            : base(options)
        {
        }

        public DbSet<Freelancing_Projects_Portal_Core_Webapp.BussinessLayer.Bid> Bid { get; set; }

        public DbSet<Freelancing_Projects_Portal_Core_Webapp.BussinessLayer.Client> Client { get; set; }

        public DbSet<Freelancing_Projects_Portal_Core_Webapp.BussinessLayer.Developer> Developer { get; set; }

        public DbSet<Freelancing_Projects_Portal_Core_Webapp.BussinessLayer.Project> Project { get; set; }
    }
}
