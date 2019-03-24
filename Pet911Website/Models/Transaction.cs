using System.Collections.Generic;

namespace Pet911Website.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Appointment Appointment { get; set; }
        public List<Item> ItemsUsed { get; set; }
        public string Remarks { get; set; }
        public double AmountCharged { get; set; }
        public double AmountPaid { get; set; }
    }
}