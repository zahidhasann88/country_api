using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CountryAPI.Models

{
    public partial class PostgresContext : DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Country> Countries { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=Country;Username=postgres;Password=15Nov1998");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasAnnotation("Relational:Collation", "English_United States.1252");
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
