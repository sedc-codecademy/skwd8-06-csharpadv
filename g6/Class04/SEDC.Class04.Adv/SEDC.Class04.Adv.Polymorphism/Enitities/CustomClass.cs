using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class04.Adv.Polymorphism.Enitities
{
    public class CustomClass
    {
        private int _id;
        public void SetId(int value)
        {
            _id = value;
        }

        public int GetId()
        {
            return _id;
        }

        private string _name;
        public string Name {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Please provide valid name");
                }
            }
        }

        // private string _someProp;
        // public string SomeProp { get { return _someProp; } }
        // public string Description { get; private set; }

        // public int Id { get; set; }
    }
}
