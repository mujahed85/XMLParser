using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLParsers.Models;

namespace XMLParsers
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=TestApp")
        {

        }
        public DbSet<TenancyContract> objTenancyContract { get; set; }
        public DbSet<PropertyDetails> objPropertyDetails { get; set; }
        public DbSet<TenantInformations> objTenantInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenancyContract>()
                .MapToStoredProcedures(s => s.Insert(u => u.HasName("InsTenancyContract", "dbo"))
                                                .Update(u => u.HasName("UpdTenancyContract", "dbo"))
                                                .Delete(u => u.HasName("DelTenancyContract", "dbo"))
                );
        }
    }
}
