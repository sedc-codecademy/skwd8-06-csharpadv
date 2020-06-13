using SEDC.Adv.Class05.ExtensionMethods.Entities;
using System;
using System.Collections.Generic;
using System.Text;

// namespace SEDC.Adv.Class05.ExtensionMethods.Piggybacking
namespace SEDC.Adv.Class05.ExtensionMethods.Entities
{
    public static class HelpersProduct
    {
       public static void GetProductId(this Product product)
       {
            Console.WriteLine(product.Id);
       }
    }
}
