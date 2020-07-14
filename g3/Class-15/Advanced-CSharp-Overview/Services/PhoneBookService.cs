using Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Services
{
    public class PhoneBookService
    {
        private FileService _fileService;

        public PhoneBookService()
        {
            _fileService = new FileService();
        }

        public List<PhoneBook> GetPhoneBooks()
        {
            return _fileService.GetAllEntities<PhoneBook>();
        }

        public PhoneBook GetPhoneBookByYear(int year)
        {
            return _fileService.GetAllEntities<PhoneBook>()
                        .First(phoneBook => phoneBook.Year == year);
        }

        public List<Contact> GetContacts(string phoneBookId)
        {
            PhoneBook phoneBook = _fileService.GetEntity<PhoneBook>(new Guid(phoneBookId));

            return phoneBook.Contacts.ToList();
        }

        public List<Contact> GetContactsByFirstNameFirstLetter(string phoneBookId, char firstLetter)
        {
            return _fileService.GetAllEntities<PhoneBook>()
                .Single(phoneBook => phoneBook.Id == new Guid(phoneBookId)).Contacts
                .Where(contact => contact.FirstName.StartsWith(firstLetter))
                .ToList();
        }

        public List<Contact> GetContactsByLastNameFirstLetter(string phoneBookId, char firstLetter)
        {
            return _fileService.GetAllEntities<PhoneBook>()
                .Single(phoneBook => phoneBook.Id == new Guid(phoneBookId)).Contacts
                .Where(contact => contact.LastName.StartsWith(firstLetter))
                .ToList();
        }

        public List<Contact> SearchContacts(string phoneBookId, string firstName = "", string lastName = "", string phoneNumber = "", string mobileNumber = "", string faxNumber = "")
        {
            return _fileService.GetAllEntities<PhoneBook>()
                .Single(phoneBook => phoneBook.Id == new Guid(phoneBookId)).Contacts
                .Where(contact => contact.FirstName.Contains(firstName))
                .Where(contact => contact.LastName.Contains(lastName))
                .Where(contact => contact.PhoneNumber.Contains(phoneNumber))
                .Where(contact => contact.MobileNumber.Contains(mobileNumber))
                .Where(contact => contact.Fax.Contains(faxNumber))
                .ToList();

            // A More optimized code doing the same thing as above, using only 1 Where
            return _fileService.GetAllEntities<PhoneBook>()
                .Single(phoneBook => phoneBook.Id == new Guid(phoneBookId)).Contacts
                .Where(contact => (
                    contact.FirstName.Contains(firstName) &&
                    contact.LastName.Contains(lastName) &&
                    contact.PhoneNumber.Contains(phoneNumber) &&
                    contact.MobileNumber.Contains(mobileNumber) &&
                    contact.Fax.Contains(faxNumber)
                )).ToList();
        }

        public void AddContact(string id, Contact contact)
        {
            PhoneBook phoneBook = _fileService.GetEntity<PhoneBook>(new Guid(id));
            phoneBook.Contacts.Add(contact);

            _fileService.UpdateEntity(phoneBook);
        }
    }
}
