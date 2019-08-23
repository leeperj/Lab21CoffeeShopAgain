using System;
using System.Collections.Generic;

namespace CoffeeShop3.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal? Funds { get; set; }
        public string Password { get; set; }
    }
}
