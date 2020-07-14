using Domain;
using Services;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        private static PhoneBook _phoneBook;

        static void Main(string[] args)
        {
            InitializeData();
            PhoneBookService phoneBookService = new PhoneBookService(_phoneBook);


            //Console.WriteLine(phoneBookService.GetContacts().Count); // For testitng
            List<Contact> allContacts = phoneBookService.GetContacts();
            foreach (Contact contact in allContacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.PhoneNumber} {contact.MobileNumber}");
            }


            Console.ReadKey();
        }

        public static void InitializeData()
        {
            Contact trajan = new Contact { Id = Guid.NewGuid(), FirstName = "Trajan", LastName = "Stevkovski", PhoneNumber = "123456789", MobileNumber = "987654321", Fax = "456789" };
            Contact dejan = new Contact { Id = Guid.NewGuid(), FirstName = "Dejan", LastName = "Blazheski", PhoneNumber = "223456789", MobileNumber = "887654321", Fax = "556789" };
            Contact tose = new Contact { Id = Guid.NewGuid(), FirstName = "Tose", LastName = "Todorovski", PhoneNumber = "323456789", MobileNumber = "787654321", Fax = "656789" };

            PhoneBook phoneBook1 = new PhoneBook
            {
                Id = Guid.NewGuid(),
                Year = 2020,
                Language = "English",
                Contacts = new List<Contact> { trajan, dejan, tose }
            };

            _phoneBook = phoneBook1;
        }
    }
}
