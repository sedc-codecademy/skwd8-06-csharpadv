using System;
using System.Collections.Generic;
using System.Text;

namespace Adv08.LoggerExample
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0) throw new InvalidUserPropertyException("age", value.ToString(), Username);
                _age = value;
            }
        }
    }
}
