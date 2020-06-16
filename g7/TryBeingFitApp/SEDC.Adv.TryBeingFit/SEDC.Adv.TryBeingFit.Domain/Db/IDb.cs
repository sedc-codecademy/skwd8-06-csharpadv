using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    // In this IDb interface we will add all the necessary methods for manipulating ANY database
    // ANY database -> We can use this interface with a local implementation as well as some other DB implementation
    // T can only be a type that inherits from BaseEntity

    // Inherit directly from BaseEntity -> IDb will inherit Id as well as Info() and IDb will have those two things
    // Generic interface that the type inherits from BaseEnty
    // -> IDb will only work with OTHER entities that have Id and Info()
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void RemoveById(int id);
        void Update(T entity);
    }
}
