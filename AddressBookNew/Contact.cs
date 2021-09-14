using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNew
{
    public class Contact
    {
        public string FirstName { get; set; } // property
        public long Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public Contact(string firstName, long phone, string address, string city, string state, int zip)
        {
            this.FirstName = firstName;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
