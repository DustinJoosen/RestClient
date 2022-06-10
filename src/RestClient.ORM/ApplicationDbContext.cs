using Microsoft.EntityFrameworkCore;
using RestClient.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Orm
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Api>()
                .HasIndex(a => a.Name)
                .IsUnique();

            modelBuilder.Entity<DataModel>()
                .HasIndex(d => d.Name)
                .IsUnique();

            modelBuilder.Entity<DataModelColumn>()
                .HasIndex(d => d.NormalizedName)
                .IsUnique();

            modelBuilder.Entity<DataType>()
                .HasIndex(d => d.Name)
                .IsUnique();

            modelBuilder.Entity<Orm.Models.Endpoint>()
                .HasIndex(e => e.Name)
                .IsUnique();
        }

        public DbSet<Api> Api { get; set; }
        public DbSet<DataModel> DataModels { get; set; }
        public DbSet<DataModelColumn> DataModelColumns { get; set; }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<Orm.Models.Endpoint> Endpoints { get; set; }
        public DbSet<EndpointHeaderArgument> EndpointHeaderArguments { get; set; }
        public DbSet<EndpointQueryString> EndpointQueryStrings { get; set; }
        public DbSet<History> Histories { get; set; }
    }
}
