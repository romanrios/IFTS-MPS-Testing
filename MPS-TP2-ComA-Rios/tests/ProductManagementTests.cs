namespace MPS_TP2.Tests
{
    public class ProductManagementTests
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
                Assert.That(product.Id, Is.EqualTo(1), "El ID del producto no es el esperado.");
                Assert.That(product.Name, Is.EqualTo("Celular"), "El nombre del producto no es el esperado.");
                Assert.That(product.Price, Is.EqualTo(1000), "El precio del producto no es el esperado.");
                Assert.That(product.Category, Is.EqualTo("Electrónica"), "La categoría del producto no es la esperada.");
            });
        }

        [Test]
        public void NoPermitirPrecioNegativo()
        {
            Assert.Throws<ArgumentException>(
                () => new Product(1, "TV", -100, "Electrónica"),
                "Se esperaba una excepción por precio negativo, pero no se lanzó ninguna."
            );
        }

        // Verificar que addProduct agrega correctamente un producto a la lista interna.
        [Test]
        public void AddProduct_AgregaCorrectamente()
        {
            var product = new Product(1, "Pan", 10, "Alimentos");
            manager.AddProduct(product);

            var encontrado = manager.FindProductByName("Pan");
            Assert.That(encontrado, Is.Not.Null, "El producto no fue encontrado luego de agregarlo.");
            Assert.That(encontrado.Name, Is.EqualTo("Pan"), "El nombre del producto encontrado no coincide con el esperado.");
        }


        // Agregar varios productos y verificar que findProductByName los encuentre correctamente por el nombre.
        [Test]
        public void FindProductByName_EncuentraProductoCorrecto()
        {
            manager.AddProduct(new Product(1, "TV", 500, "Electrónica"));
            manager.AddProduct(new Product(2, "Leche", 50, "Alimentos"));

            var producto = manager.FindProductByName("Leche");
            Assert.That(producto, Is.Not.Null, "El producto no fue encontrado.");
            Assert.That(producto.Id, Is.EqualTo(2), "El ID del producto encontrado no coincide con el esperado.");
        }

        // Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Electrónica".
        [Test]
        public void CalculateTotalPrice_Electronica()
        {
            var product = new Product(1, "Laptop", 1000, "Electrónica");
            var total = manager.CalculateTotalPrice(product);

            Assert.That(total, Is.EqualTo(1100), "El precio total con impuestos para 'Electrónica' no es correcto.");

        }

        // Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Alimentos".
        [Test]
        public void CalculateTotalPrice_Alimentos()
        {
            var product = new Product(1, "Queso", 100, "Alimentos");
            var total = manager.CalculateTotalPrice(product);

            Assert.That(total, Is.EqualTo(105), "El precio total con impuestos para 'Alimentos' no es correcto.");
        }
    }
}
