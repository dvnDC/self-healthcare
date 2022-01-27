// #nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using self_healthcare.Models;

    public class SelfHealthcareContext : DbContext
    {
        public SelfHealthcareContext (DbContextOptions<SelfHealthcareContext> options)
            : base(options)
        {
        }

        public DbSet<self_healthcare.Models.Movie> Movie { get; set; }
        public DbSet<self_healthcare.Models.Food> Food { get; set; }
        public DbSet<self_healthcare.Models.Diet> Diet { get; set; }
        
    }
