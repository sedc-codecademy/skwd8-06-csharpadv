using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.Class11.Disposing.Where
{
    public class Db<T> where T : BaseEntity
    {
        private List<T> entites; // this is colection of clasess that inherit base entity

        public T FindById(int id)
        {
            return entites.FirstOrDefault(x => x.Id == id);
            //entites.Where(x => x.Id == id);
            //entites.OrderBy(x => x.CreateOn).Take(100);
        }

        public void FindBySomething(Func<T, bool> filter)
        {
            entites.Where(filter);
        }

        public void ListAllItems<H>(List<H> list) where H : User
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
