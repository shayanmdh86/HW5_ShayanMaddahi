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
            product.Name = "Tele1_33";
            product.Barcode = "1";
            productrep.AddProduct(product);

        }
    }
}