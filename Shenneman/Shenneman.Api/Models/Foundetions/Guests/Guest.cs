using System;

namespace Shenneman.Api.Models.Foundetions.Guests
{
    public class Guest
    {
        public  int  Id { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public  DateTime DateOfBrith { get; set; }
        public  string Email  { get; set; }
        public  string PhoneNumber { get; set; }
        public  string Address { get; set; }
        public  GenderType Gender { get; set; }
    }
}
