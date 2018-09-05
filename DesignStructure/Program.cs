using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                Product type = new Product();
                IProduct productType = type.GetProduct(input);
                string ExtractType = productType.GetTypeOfProduct();
                productType.Book();
                productType.Save();
                Console.ReadKey();
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
