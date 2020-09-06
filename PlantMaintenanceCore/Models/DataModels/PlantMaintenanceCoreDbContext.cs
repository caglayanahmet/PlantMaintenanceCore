using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantMaintenanceCore.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace PlantMaintenanceCore.Models.DataModels
{
    public class PlantMaintenanceCoreDbContext:DbContext
    {
        public PlantMaintenanceCoreDbContext(DbContextOptions<PlantMaintenanceCoreDbContext> options) : base(options)
        {
        }

        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<BreakdownType> BreakdownTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Breakdown> Breakdowns { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
    
}
