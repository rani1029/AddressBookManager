﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AddressBookNew
{
    class ContactDetails
    {
        List<Contact> contactlist = new List<Contact>();
        //uc-6
        public static Dictionary<string, List<Contact>> contactsDictionary = new Dictionary<string, List<Contact>>();
        public void AddContact()
        {

            //adding contacts 
            Console.WriteLine("Enter your first Name");
            var FirstName = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            var Phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            var Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            var City = Console.ReadLine();
            Console.WriteLine("Enter State");
            var State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            var Zip = int.Parse(Console.ReadLine());
            Contact _contact = new Contact(FirstName, Phone, Address, City, State, Zip);
            contactlist.Add(_contact); //add opration of list
        }
        public void Display()
        {
            foreach (Contact con in contactlist)
            {
                Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
            }
        }
        // uc-3
        public void EditContact()
        {

            Console.WriteLine(" enter firstName to modify contact details of a person ");
            string UserFirstname = Console.ReadLine();
            foreach (Contact con in contactlist)
            {
                // Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
                if (con.FirstName.Equals(UserFirstname))
                {
                    Console.WriteLine("what data u want to edit,press first character only  of that field");
                    char userinput = char.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 'a':
                            Console.WriteLine(" enter address");
                            con.Address = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.Address);
                            break;
                        case 'p':
                            Console.WriteLine(" enter Phone");
                            con.Phone = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + con.Phone);
                            break;
                        case 'f':
                            Console.WriteLine(" enter firstname");
                            con.FirstName = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.FirstName);
                            break;
                        case 'c':
                            Console.WriteLine(" enter city");
                            con.City = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.City);
                            break;
                        case 's':
                            Console.WriteLine(" enter state");
                            con.State = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.State);
                            break;
                        case 'z':
                            Console.WriteLine(" enter address");
                            con.Zip = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + con.Zip);
                            break;

                        default:
                            Console.WriteLine("wrong input ");
                            break;
                    }
                }

            }
        }
        //uc-4
        public void DeleteContact()
        {

            Console.WriteLine(" enter firstName to delete the contact ");
            string UserFirstname = Console.ReadLine();
            foreach (Contact con in contactlist)
            {
                // Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
                if (con.FirstName.Equals(UserFirstname))
                {
                    contactlist.Remove(con);
                    break;
                }

            }
        }
        Display();
        public void AddNewAddressBook()
        {
            Console.Write("Creating a new AddressBook. " + "\nPlease Enter Name : ");
            string NewadrBookName = Console.ReadLine();
            if (contactsDictionary.ContainsKey(NewadrBookName))
            {
                Console.WriteLine(" This name already exists.. Please add new name..");
                AddNewAddressBook();
            }
            else
            {
                Console.WriteLine("List of Address Books : ");
                Console.WriteLine("------------------------");
                foreach (var ab in contactsDictionary)
                {
                    Console.Write("\t" + ab.Key);
                }
                Console.WriteLine("Adding person details on new addressbook");
                var newContact = AddContact();
                contactsDictionary.Add(NewadrBookName, newContact);
                DisplayContacts(NewadrBookName);
            }
        }
        //uc-6
        static void DisplayContacts(string AddNewAddressBook)
        {

            if (contactsDictionary[AddNewAddressBook].Count > 0)
            {
                Console.WriteLine(" Displaying contacts in addresss book : " + AddNewAddressBook);
                foreach (Contact person in contactsDictionary[AddNewAddressBook])
                {
                    Console.WriteLine(person.FirstName);
                }
            }
            else
            {
                Console.WriteLine(" No contacts Present. Please add new contact. \n");
            }
        }




    }
}
