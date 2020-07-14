using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PhoneBook : IBaseEntity
    {
        public Guid Id{ get; set; }
        public string Language{ get; set; }
        public int Year{ get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
