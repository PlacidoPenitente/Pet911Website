namespace Pet911Website.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Staffs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        EmailAddress = c.String(),
                        FacebookLink = c.String(),
                        InstagramLink = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
        }
    }
}
