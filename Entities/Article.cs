namespace ShoppingCommand.Entities
{
    public class Article
    {
        public Article(string id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
