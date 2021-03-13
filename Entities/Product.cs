namespace ShoppingCommand.Entities
{
    public class Product
    {
        public Product(string id, string name, int quantityInStock)
        {
            Id = id;
            Name = name;
            QuantityInStock = quantityInStock;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }

        public override string ToString()
            => $"Id: {Id}, Name: {Name}, Quantity in stock: {QuantityInStock}";
    }
}
