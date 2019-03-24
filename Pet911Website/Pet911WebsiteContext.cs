using System.Data.Entity;

public class Pet911WebsiteContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public Pet911WebsiteContext() : base("name=Pet911WebsiteContext")
    {
    }

    public System.Data.Entity.DbSet<Pet911Website.Models.AnimalKind> AnimalKinds { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Client> Clients { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Staff> Staffs { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Pet> Pets { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Breed> Breeds { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Service> Services { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Appointment> Appointments { get; set; }

    public System.Data.Entity.DbSet<Pet911Website.Models.Transaction> Transactions { get; set; }
}
