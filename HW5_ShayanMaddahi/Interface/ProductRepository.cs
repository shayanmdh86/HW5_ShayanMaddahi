﻿using HW5_ShayanMaddahi.Domain;

namespace HW5_ShayanMaddahi.Interface
{
    public class ProductRepository : IProductRepository
    {
<<<<<<< Updated upstream
        public string AddProduct(Product product)
        {
            throw new NotImplementedException();

            CheckProductName(product.Name);

=======
        bool Test;
        List<Product> products = new List<Product>();

        public ProductRepository()
        {


        }

        public string AddProduct(Product product)
        {
            try { CheckProductName(product.Name); }
            catch (IncorrectNameFormatException ex) { Console.WriteLine($"Exception : {ex.Message}"); }  
            if (Test)
            {
                products.Add(product);
            }
>>>>>>> Stashed changes
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


<<<<<<< Updated upstream
        public void CheckProductName(string name)
        {
            //Tel101_
            Regex regex = new Regex(@"^[A-X][a-x]{2}[1-9]{3}_$");
            bool TestName = regex.IsMatch(name);
            if (!TestName)
            {
                Console.WriteLine("not correct!!");
            }


=======
            return Test;
>>>>>>> Stashed changes
        }

    }
}
