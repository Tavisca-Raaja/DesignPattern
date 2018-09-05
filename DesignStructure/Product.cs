using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStructure
{
    class Product
    {
        public IProduct GetProduct(string productType)
        {
            switch(productType)
            {
                case "Car":return new CarProduct();
                case "Activity": return new ActivityProduct();
                case "Hotel": return new HotelProduct();
                case "Air": return new AirProduct();
                default:throw new Exception("Enter valid product");

            }
        }
    }
}
