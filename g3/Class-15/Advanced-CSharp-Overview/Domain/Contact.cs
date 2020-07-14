using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Contact : IBaseEntity
    {
        public Guid Id{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string PhoneNumber{ get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
    }
}
