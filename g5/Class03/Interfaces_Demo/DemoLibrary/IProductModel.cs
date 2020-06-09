using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// New interface IProductModel with two properties and one method ShipItem.
    /// Every class that imlpements this interface(contract), will need to provide
    /// implementation for all of them. In that class, we are not limmited to have
    /// just these properties, we can have other properties, methods specific to that class..
    /// 
    /// </summary>
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; set; }
        void ShipItem(CustomerModel customer);
    }
}
