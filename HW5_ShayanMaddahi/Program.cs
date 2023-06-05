using HW5_ShayanMaddahi.Domain;
using HW5_ShayanMaddahi.Interface;

namespace HW5_ShayanMaddahi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productrep = new ProductRepository();
            Product product = new Product();

            product.ProductId = 1;
            product.Name = "Te14le1_Ab";
            product.Barcode = "1";
            productrep.AddProduct(product);

        }
    }
}