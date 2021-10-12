using eVoucher.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eVoucher.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes().ToList())
            {
                // Replace table names
                entity.SetTableName(entity.GetTableName().ToLower());

                // Replace column names
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName(StoreObjectIdentifier.Table(entity.GetTableName(), null)).ToLower());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToLower());
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.SetConstraintName(key.GetConstraintName().ToLower());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName().ToLower());
                }
            }
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is Base && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((Base)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Base)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<BuyType> BuyTypes {get;set;}
        public DbSet<Voucher> Vouchers {get;set;}
        public DbSet<DiscountType> DiscountTypes {get;set;}

    }
}