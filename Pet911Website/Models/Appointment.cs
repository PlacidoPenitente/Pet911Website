using System;

namespace Pet911Website.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Pet Pet { get; set; }
        public Service Service { get; set; }
        public DateTime? Schedule { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}