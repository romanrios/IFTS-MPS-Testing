namespace MPS_TP2
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public string Category { get; }

        public Product(int id, string name, decimal price, string category)
        {
            if (price < 0)
                throw new ArgumentException("El precio no puede ser negativo");

            if (category != "Electrónica" && category != "Alimentos")
                throw new ArgumentException("Categoría inválida");

            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
