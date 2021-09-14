using System;
using System.IO;
namespace AddressBookNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressBook management system");
            //uc-2
            ContactDetails contactDetails = new ContactDetails();
            //uc-5 // uc 7
            contactDetails.AddContact();
            //uc-3
            //contactDetails.EditContact();
            ////uc4
            //contactDetails.DeleteContact();
            //// uc- 6
            //contactDetails.AddNewAddressBook();
            ////uc-13
            //contactDetails.Writefile(@"C:\Users\admin\Desktop\Terminalcommands\cloned_masterCsharpprograms\AddressBookManager\AddressBookNew\ContactListFile.json");
            contactDetails.ReadFile(@"C:\Users\admin\Desktop\Terminalcommands\cloned_masterCsharpprograms\AddressBookManager\AddressBookNew\ContactListFile.json");
        }
    }
}
