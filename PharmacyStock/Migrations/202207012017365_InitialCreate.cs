namespace PharmacyStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ScienceName = c.String(),
                        StorageTemprature = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DrugInSuppliedBills",
                c => new
                    {
                        BillID = c.Int(nullable: false),
                        DrugWithExpirationID = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BillID, t.DrugWithExpirationID })
                .ForeignKey("dbo.DrugWithExpirations", t => t.DrugWithExpirationID, cascadeDelete: true)
                .ForeignKey("dbo.SupplyBills", t => t.BillID, cascadeDelete: true)
                .Index(t => t.BillID)
                .Index(t => t.DrugWithExpirationID);
            
            CreateTable(
                "dbo.DrugWithExpirations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DrugID = c.Int(nullable: false),
                        ManufacturingDate = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Drugs", t => t.DrugID, cascadeDelete: true)
                .Index(t => t.DrugID);
            
            CreateTable(
                "dbo.SupplyBills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PharmacistID = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        DateofEntry = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pharmacists", t => t.PharmacistID, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.PharmacistID)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BranchID = c.Int(nullable: false),
                        Name = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        Branch_ID = c.Int(nullable: false),
                        Accounts_UserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Accounts_UserName)
                .ForeignKey("dbo.Branches", t => t.Branch_ID, cascadeDelete: true)
                .Index(t => t.Branch_ID)
                .Index(t => t.Accounts_UserName);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Branch_ID = c.Int(nullable: false, identity: true),
                        Branch_Name = c.String(),
                        Branch_Address = c.String(),
                    })
                .PrimaryKey(t => t.Branch_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DrugInSuppliedBills", "BillID", "dbo.SupplyBills");
            DropForeignKey("dbo.SupplyBills", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.SupplyBills", "PharmacistID", "dbo.Pharmacists");
            DropForeignKey("dbo.Pharmacists", "Branch_ID", "dbo.Branches");
            DropForeignKey("dbo.Pharmacists", "Accounts_UserName", "dbo.Accounts");
            DropForeignKey("dbo.DrugInSuppliedBills", "DrugWithExpirationID", "dbo.DrugWithExpirations");
            DropForeignKey("dbo.DrugWithExpirations", "DrugID", "dbo.Drugs");
            DropIndex("dbo.Pharmacists", new[] { "Accounts_UserName" });
            DropIndex("dbo.Pharmacists", new[] { "Branch_ID" });
            DropIndex("dbo.SupplyBills", new[] { "SupplierID" });
            DropIndex("dbo.SupplyBills", new[] { "PharmacistID" });
            DropIndex("dbo.DrugWithExpirations", new[] { "DrugID" });
            DropIndex("dbo.DrugInSuppliedBills", new[] { "DrugWithExpirationID" });
            DropIndex("dbo.DrugInSuppliedBills", new[] { "BillID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Branches");
            DropTable("dbo.Accounts");
            DropTable("dbo.Pharmacists");
            DropTable("dbo.SupplyBills");
            DropTable("dbo.DrugWithExpirations");
            DropTable("dbo.DrugInSuppliedBills");
            DropTable("dbo.Drugs");
        }
    }
}
