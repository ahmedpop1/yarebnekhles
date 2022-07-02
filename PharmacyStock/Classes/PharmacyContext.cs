using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class PharmacyContext : DbContext
    {
        public PharmacyContext() : base("name=DefaultConnection")
        { }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugInSuppliedBill> DrugsInSuppliedBill { get; set; }

        public DbSet<DrugWithExpiration> DrugsWithExpiration { get; set; }
        public DbSet<Pharmacist> pharmacists { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyBill> supplyBills { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet <Branch> Branches { get; set; }
        public DbSet<Manger> Mangers { get; set; }

        public DbSet<Stored_Drug> Stored_Drugs { get; set; }

        public DbSet<Sell_Bill> Sell_Bills { get; set; }


        public DbSet<DrugIn_SoldBill> drugIn_SoldBills { get; set; }

        public DbSet<Replace_Drug> Replace_Drugs { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Stored_Drug>()
        //        .HasKey(c => new { c.Branch_ID, c.DrugWithExpirationID });
        //}














    }
}
