using HW5_ShayanMaddahi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5_ShayanMaddahi.Interface
{
    public class ProductRepository : IProductRepository
    {
        bool Test;
        public string AddProduct(Product product)
        {
            CheckProductName(product.Name);
            if (Test)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("NOt ok");
            }

            return "done";
        }

        public string GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }

        private bool CheckProductName(string name)
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{3}[1-9]{1}[_]{1}[1-9]{2}$");
            Test =regex.IsMatch(name);
            if (!Test)
                Console.WriteLine("product name is not correct");

            return Test;

        }
    }
}
