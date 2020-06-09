using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// We create new interface because our 'client' wanted us to
    /// show to the user total downloads left, but that property
    /// was not in the interface(contract) IProductModel, because it is just specific to that class DigitalProductModel.
    /// Instead of modifying IProduct interface, we create new interface with that property TotalDownloadsLeft.
    /// DigitalProductModel class already implements IProduct interface, so we can 'extend' the new interface
    /// IDigitalProductModel with the contract that we already had for IProductModel. Thats what we are doing with 
    /// IDigitalProductModel : IProductModel, we say every class that implementes IDigitalProductModel interface,
    /// besides they need need to provide implementation for TotalDownloadsLeft, classes will need to provide
    /// an implementation for all the methods and propertis from IProductModel. So, it looks like DigitalProductModel class
    /// will implement just the IDigitalProductModel interface, but because IDigitalProductModel extends the contract from
    /// IProductModel, it will actually implement both of the interfaces..
    /// </summary>
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; set; }
    }
}
