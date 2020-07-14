using Domain;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        private static PhoneBookService _phoneBookService;

        static void Main(string[] args)
        {
            _phoneBookService = new PhoneBookService();

            #region Data For Testing
            //PhoneBook fakePhoneBook = MakeFakePhoneBook();
            //Console.WriteLine(JsonConvert.SerializeObject(fakePhoneBook));
            #endregion

            Console.WriteLine("Choose a phonebook by year");
            foreach (PhoneBook phoneBook in _phoneBookService.GetPhoneBooks())
            {
                Console.WriteLine($"* {phoneBook.Year}");
            }
            Console.WriteLine("\nEnter a year from above:");
            int userYear = int.Parse(Console.ReadLine());

            PhoneBook userPhoneBook = _phoneBookService.GetPhoneBookByYear(userYear);

            #region Print All Contacts
            Console.WriteLine($"\nAll contacts from phonebook of {userPhoneBook.Year}:");

            List<Contact> allContacts = _phoneBookService.GetContacts(userPhoneBook.Id.ToString());
            foreach (Contact contact in allContacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.PhoneNumber} {contact.MobileNumber}");
            }
            #endregion

            #region Print Contacts by FirstName letter
            Console.WriteLine("\nEnter a first letter of First Names:");
            char userInputFirstLetter = Console.ReadLine().First();

            List<Contact> contactsByFirstNameLetter = _phoneBookService.GetContactsByFirstNameFirstLetter(userPhoneBook.Id.ToString(), userInputFirstLetter);
            Console.WriteLine($"\nAll contacts starting with letter: {userInputFirstLetter}");
            foreach (Contact contact in contactsByFirstNameLetter)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.PhoneNumber} {contact.MobileNumber}");
            }
            #endregion

            #region Search Contacts
            Console.WriteLine("\nSearch contacts by last name.\nEnter a last name:");
            string userInputLastName = Console.ReadLine();

            List<Contact> contactsBySearch = _phoneBookService.SearchContacts(userPhoneBook.Id.ToString(), lastName: userInputLastName);
            foreach (Contact contact in contactsBySearch)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.PhoneNumber} {contact.MobileNumber}");
            }
            #endregion


            Console.ReadKey();
        }

        public static PhoneBook MakeFakePhoneBook()
        {
            Contact trajan = new Contact { Id = Guid.NewGuid(), FirstName = "Trajan", LastName = "Stevkovski", PhoneNumber = "123456789", MobileNumber = "987654321", Fax = "456789" };
            Contact dejan = new Contact { Id = Guid.NewGuid(), FirstName = "Dejan", LastName = "Blazheski", PhoneNumber = "223456789", MobileNumber = "887654321", Fax = "556789" };
            Contact tose = new Contact { Id = Guid.NewGuid(), FirstName = "Tose", LastName = "Todorovski", PhoneNumber = "323456789", MobileNumber = "787654321", Fax = "656789" };

            PhoneBook fakePhoneBook = new PhoneBook
            {
                Id = Guid.NewGuid(),
                Year = 2020,
                Language = "English",
                Contacts = new List<Contact> { trajan, dejan, tose }
            };

            return fakePhoneBook;
        }
    }
}
