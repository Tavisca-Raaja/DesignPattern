using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStructure
{
    class HotelProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return string.Empty;
        }
        public void Save()
        {
            Console.WriteLine("saving");
        }
        public void Book()
        {
            Console.WriteLine("Booking");
        }
    }
}
