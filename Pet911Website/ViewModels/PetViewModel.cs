using System.Collections.Generic;
using Pet911Website.Models;

namespace Pet911Website.ViewModels
{
    public class PetViewModel
    {
        public Pet Pet { get; set; }
        public List<Client> Clients { get; set; }
        public List<Breed> Breeds { get; set; }
    }
}