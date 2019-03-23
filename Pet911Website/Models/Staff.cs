using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet911Website.Models
{
    public class Staff
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
        public string Username { get; set; }
        public string Password { get; set; }
        public Position Position { get; set; }
    }
}