namespace Pet911Website.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AnimalKind AnimalKind { get; set; }
    }
}