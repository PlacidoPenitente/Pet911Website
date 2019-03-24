namespace Pet911Website.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AnimalKind : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalKinds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AnimalKinds");
        }
    }
}
