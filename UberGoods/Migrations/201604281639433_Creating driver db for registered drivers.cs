namespace UberGoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creatingdriverdbforregistereddrivers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        CarBrand = c.String(),
                        CarModel = c.String(),
                        CreditCard = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
