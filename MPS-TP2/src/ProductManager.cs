namespace MPS_TP2
{
    public class ProductManager
    {
        private readonly List<Product> products = [];

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalPrice(Product product)
        {
            decimal taxRate = product.Category == "Electrónica" ? 0.10m : 0.05m;
            return product.Price * (1 + taxRate);
        }

        public Product? FindProductByName(string name)
        {
            return products.Find(p => p.Name == name);
        }
    }
}
