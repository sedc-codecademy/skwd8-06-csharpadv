using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class PhoneBookService
    {
        private PhoneBook _phoneBook;

        public PhoneBookService(PhoneBook phoneBook)
        {
            _phoneBook = phoneBook;
        }

        public List<Contact> GetContacts()
        {
            return _phoneBook.Contacts.ToList();
        }

        //public List<Contact> GetContactsByFirstLetter()
        //{
        //    //To Implement
        //}

        //public List<Contact> GetContactsByLastLetter()
        //{
        //    //To Implement
        //}

        //public List<Contact> SearchContacts()
        //{
        //    //To Implement
        //}

        public void AddContact(Contact contact)
        {
            _phoneBook.Contacts.Add(contact);
        }
    }
}
