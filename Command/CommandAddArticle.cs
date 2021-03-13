namespace ShoppingCommand.Command
{
    using ShoppingCommand.Entities;
    using ShoppingCommand.Repositories.Produit;
    using System.Linq;

    public class CommandAddArticle : ICommand
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly Article _article;

        public CommandAddArticle(
            IProductRepository productRepository,
            ShoppingCart shoppingCart,
            Article article)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
            _article = article;
        }

        public bool CanExecute()
            => _article != null;

        public void Execute()
        {
            _productRepository.DecreaseQuantity(_article.Id, _article.Quantity);
            _shoppingCart.Articles.Add(_article);
        }

        public void Undo()
        {
            _productRepository.IncreaseQuantity(_article.Id, _article.Quantity);
            _shoppingCart.Articles.Remove(_shoppingCart.Articles.Last(e => e.Id == _article.Id));
        }
    }
}
