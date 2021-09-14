using System;

namespace AddressBookNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressBook management system");
            //uc-2
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.AddContact();
            contactDetails.EditContact();
        }
    }
}
