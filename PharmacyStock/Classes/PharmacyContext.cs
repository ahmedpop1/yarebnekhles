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

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Pharmacist> pharmacists { get; set; }
        public DbSet<SupplyBill> supplyBills { get; set; }  

    }
}
