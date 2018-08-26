using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimatePlanetaryDatabase.Models;

namespace UltimatePlanetaryDatabase.DatabaseAccess
{
    public class PlanetaryDatabaseContext : DbContext
    {

        public PlanetaryDatabaseContext ()
        {

        }

        //public virtual DbSet<KerPlanet> KerPlanet { get; set; }
        public virtual DbSet<KerPlanet> KerPlanets { get; set; }
        public virtual DbSet<KerMoon> KerMoons { get; set; }
        public virtual DbSet<GalPlanet> GalPlanets { get; set; }
        public virtual DbSet<GalMoon> GalMoons { get; set; }
        public virtual DbSet<SolPlanet> SolPlanets { get; set; }
        public virtual DbSet<SolMoon> SolMoons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<KerPlanet>().HasKey(c => c.Identifier);
            //modelBuilder.Entity<KerMoon>().HasKey(c => c.Id);
            //modelBuilder.Entity<GalPlanet>().HasKey(c => c.Id);
            //modelBuilder.Entity<GalMoon>().HasKey(c => c.Id);
            //modelBuilder.Entity<SolPlanet>().HasKey(c => c.Id);
            //modelBuilder.Entity<SolMoon>().HasKey(c => c.Id);
            //modelBuilder.Ignore<Vehicle>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
