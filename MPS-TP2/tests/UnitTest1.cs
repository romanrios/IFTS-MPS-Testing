namespace MPS_TP2
{
    public class UnitTest1
    {
        private ProductManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new ProductManager();
        }

        // Verificar que un producto se crea correctamente con un id, name, price y category válidos.
        [Test]
        public void CrearProductoCorrectamente()
        {
            var product = new Product(1, "Celular", 1000, "Electrónica");

            Assert.Multiple(() =>
            {
                Assert.That(product.Id, Is.EqualTo(1));
                Assert.That(product.Name, Is.EqualTo("Celular"));
                Assert.That(product.Price, Is.EqualTo(1000));
                Assert.That(product.Category, Is.EqualTo("Electrónica"));
            });
        }

        [Test]
        public void NoPermitirPrecioNegativo()
        {
            Assert.Throws<ArgumentException>(() => new Product(1, "TV", -100, "Electrónica"));
        }

        // Verificar que addProduct agrega correctamente un producto a la lista interna.
        [Test]
        public void AddProduct_AgregaCorrectamente()
        {
            var product = new Product(1, "Pan", 10, "Alimentos");
            manager.AddProduct(product);

            var encontrado = manager.FindProductByName("Pan");
            Assert.That(encontrado, Is.Not.Null);
            Assert.That(encontrado.Name, Is.EqualTo("Pan"));
        }


        // Agregar varios productos y verificar que findProductByName los encuentre correctamente por el nombre.
        [Test]
        public void FindProductByName_EncuentraProductoCorrecto()
        {
            manager.AddProduct(new Product(1, "TV", 500, "Electrónica"));
            manager.AddProduct(new Product(2, "Leche", 50, "Alimentos"));

            var producto = manager.FindProductByName("Leche");
            Assert.That(producto, Is.Not.Null);
            Assert.That(producto.Id, Is.EqualTo(2));
        }

        // Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Electrónica".
        [Test]
        public void CalculateTotalPrice_Electronica()
        {
            var product = new Product(1, "Laptop", 1000, "Electrónica");
            var total = manager.CalculateTotalPrice(product);

            Assert.That(total, Is.EqualTo(1100));
        }

        [Test]

        // Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Alimentos".
        public void CalculateTotalPrice_Alimentos()
        {
            var product = new Product(1, "Queso", 100, "Alimentos");
            var total = manager.CalculateTotalPrice(product);

            Assert.That(total, Is.EqualTo(105));
        }
    }
}
