using System;

namespace Pet911Website.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
    }
}