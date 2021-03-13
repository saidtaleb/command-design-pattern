namespace ShoppingCommand
{
    using ShoppingCommand.Command;
    using ShoppingCommand.Entities;
    using ShoppingCommand.Repositories.Produit;
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();
            var shoppingCart = new ShoppingCart();

            var article1 = new Article("1", "Produit 1", 2);
            var command1 = new CommandAddArticle(repository, shoppingCart, article1);

            var article2 = new Article("2", "Produit 2", 4);
            var command2 = new CommandAddArticle(repository, shoppingCart, article2);

            var commandManager = new CommandManager();

            commandManager.Invoke(command1);
            ShowAllProducts(repository);

            commandManager.Invoke(command2);
            ShowAllProducts(repository);

            commandManager.Undo();
            ShowAllProducts(repository);

            Console.ReadKey();
        }

        private static void ShowAllProducts(ProductRepository repository)
        {
            var produits = repository
                            .GetAll()
                            .Aggregate("", (previous, current) => $"{previous} {Environment.NewLine} {current}");
            Console.WriteLine(produits);
        }
    }
}
