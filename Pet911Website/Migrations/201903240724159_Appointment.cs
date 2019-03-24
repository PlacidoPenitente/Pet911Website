namespace Pet911Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Appointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Schedule = c.DateTime(),
                        DateAdded = c.DateTime(),
                        Client_Id = c.Int(),
                        Pet_Id = c.Int(),
                        Service_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Pets", t => t.Pet_Id)
                .ForeignKey("dbo.Services", t => t.Service_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Pet_Id)
                .Index(t => t.Service_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Appointments", "Pet_Id", "dbo.Pets");
            DropForeignKey("dbo.Appointments", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Appointments", new[] { "Service_Id" });
            DropIndex("dbo.Appointments", new[] { "Pet_Id" });
            DropIndex("dbo.Appointments", new[] { "Client_Id" });
            DropTable("dbo.Appointments");
        }
    }
}
