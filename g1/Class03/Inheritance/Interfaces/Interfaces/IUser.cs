using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IUser
    {
        public int Age { get; set; }
        void SayHi();
        int GetAge();
        void SetName(string name);
    }
}
