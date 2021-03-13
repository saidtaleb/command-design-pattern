namespace ShoppingCommand.Entities
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Articles = new List<Article>(); 
        }

        public ICollection<Article> Articles { get; set; }
        public int CountArticles() => Articles.Count();
        public int TotalQuantity() => Articles.Sum(e => e.Quantity);
    }
}
