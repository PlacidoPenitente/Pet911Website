namespace Pet911Website.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Transaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remarks = c.String(),
                        AmountCharged = c.Double(nullable: false),
                        AmountPaid = c.Double(nullable: false),
                        Appointment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.Appointment_Id)
                .Index(t => t.Appointment_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Transaction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transactions", t => t.Transaction_Id)
                .Index(t => t.Transaction_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Transaction_Id", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "Appointment_Id", "dbo.Appointments");
            DropIndex("dbo.Items", new[] { "Transaction_Id" });
            DropIndex("dbo.Transactions", new[] { "Appointment_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.Transactions");
        }
    }
}
