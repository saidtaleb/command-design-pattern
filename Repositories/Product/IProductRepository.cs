namespace ShoppingCommand.Repositories.Produit
{
    using ShoppingCommand.Entities;
    using System.Collections.Generic;

    public interface IProductRepository
    {
        ICollection<Product> GetAll();
        Product FindById(string id);
        void DecreaseQuantity(string id, int quantity);
        void IncreaseQuantity(string id, int quantity);
    }
}
