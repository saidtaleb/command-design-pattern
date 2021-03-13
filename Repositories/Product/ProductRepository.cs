namespace ShoppingCommand.Repositories.Produit
{
    using ShoppingCommand.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductRepository : IProductRepository
    {
        private readonly ICollection<Product> _produits = new List<Product>()
        {
            new Product("1","Produit 1",10),
            new Product("2","Produit 2",20),
            new Product("3","Produit 3",15),
            new Product("4","Produit 4",12),
            new Product("5","Produit 5",08),
            new Product("6","Produit 6",05),
            new Product("7","Produit 7",03),
            new Product("8","Produit 8",17),
            new Product("9","Produit 9",19),
        };

        public void DecreaseQuantity(string id, int quantity)
            => _produits.First(e => e.Id == id).QuantityInStock -= quantity;

        public Product FindById(string id)
            => _produits.FirstOrDefault(e => e.Id == id);

        public ICollection<Product> GetAll()
            => _produits;

        public void IncreaseQuantity(string id, int quantity)
            => _produits.First(e => e.Id == id).QuantityInStock += quantity;
    }
}
