namespace Pet911Website.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Pets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(),
                        Breed_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Breeds", t => t.Breed_Id)
                .ForeignKey("dbo.Clients", t => t.Owner_Id)
                .Index(t => t.Breed_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        AnimalKind_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalKinds", t => t.AnimalKind_Id)
                .Index(t => t.AnimalKind_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "Owner_Id", "dbo.Clients");
            DropForeignKey("dbo.Pets", "Breed_Id", "dbo.Breeds");
            DropForeignKey("dbo.Breeds", "AnimalKind_Id", "dbo.AnimalKinds");
            DropIndex("dbo.Breeds", new[] { "AnimalKind_Id" });
            DropIndex("dbo.Pets", new[] { "Owner_Id" });
            DropIndex("dbo.Pets", new[] { "Breed_Id" });
            DropTable("dbo.Breeds");
            DropTable("dbo.Pets");
        }
    }
}
