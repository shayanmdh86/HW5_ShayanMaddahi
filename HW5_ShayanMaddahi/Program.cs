namespace HW5_ShayanMaddahi
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello, World!");
=======
            ProductRepository productrep = new ProductRepository();
            Product product = new Product();

            product.ProductId = 1;
            product.Name = "Tel101_";
            product.Barcode = "1";
            productrep.AddProduct(product);

>>>>>>> Stashed changes
        }
    }
}