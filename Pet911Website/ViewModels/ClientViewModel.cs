using System.Collections.Generic;
using Pet911Website.Models;

namespace Pet911Website.ViewModels
{
    public class ClientViewModel
    {
        public Client Client { get; set; }
        public List<Pet> Pets { get; set; }
    }
}