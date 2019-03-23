using System;

namespace Pet911Website.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetGender Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public Breed Breed { get; set; }
        public Client Owner { get; set; }

    }
}