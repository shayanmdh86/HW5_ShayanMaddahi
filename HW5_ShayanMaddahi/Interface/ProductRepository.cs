using HW5_ShayanMaddahi.Domain;

namespace HW5_ShayanMaddahi.Interface
{
    public class ProductRepository : IProductRepository
    {
        public string AddProduct(Product product)
        {
            throw new NotImplementedException();

            CheckProductName(product.Name);

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


        public void CheckProductName(string name)
        {
            //Tel101_
            Regex regex = new Regex(@"^[A-X][a-x]{2}[1-9]{3}_$");
            bool TestName = regex.IsMatch(name);
            if (!TestName)
            {
                Console.WriteLine("not correct!!");
            }


        }

    }
}
