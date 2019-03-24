using System.Collections.Generic;
using Pet911Website.Models;

namespace Pet911Website.ViewModels
{
    public class AnimalKindViewModel
    {
        public AnimalKind AnimalKind { get; set; }
        public List<Breed> Breeds { get; set; }
    }
}