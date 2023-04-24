using GameShopBack.DataAccess.EntityFramework;
using GameShopBack.DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameShopBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameBasketController : ControllerBase
    {
        private readonly GameBasketRepository _gameBasketRepository;
        private readonly GameRepository _gameRepository;
        private readonly BasketRepository _basketRepository;


        public GameBasketController(GameBasketRepository gameBasketRepository, GameRepository gameRepository, BasketRepository basketRepository)
        {
            _gameBasketRepository = gameBasketRepository;
            _basketRepository = basketRepository;
            _gameRepository = gameRepository;
        }

        [HttpPost("{gameId}")]
        public GameBasket PostGameBasket([FromRoute]Guid gameId)
        {
            var game = _gameRepository.GetGameById(gameId);
            var basket = _basketRepository.GetBasketById(Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8"));
            if (basket.GameBaskets.Any(b => b.GameId == gameId))
            {
                var ifExists = new GameBasket
                {
                    BasketId = Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8"),
                    GameId = gameId,
                    ProductCount = 1,
                    Price = game.Price
                };
                var gameBasket = _gameBasketRepository.GetGameBasketByGameId(gameId);
                gameBasket.ProductCount += 1;
                gameBasket.Price += game.Price;
                _gameBasketRepository.Save();
                return ifExists;
            }
            var item = new GameBasket
            {
                BasketId = Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8"),
                GameId = gameId,
                ProductCount = 1,
                Price = game.Price
            };
            _gameBasketRepository.AddGameBasket(item);
            _gameBasketRepository.Save();
            return item;
        }

        [HttpGet]
        public Basket GetBasket()
        {
            return _basketRepository.GetBasketById(Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8"));
        }

        [HttpDelete]
        public void EmptyBasket()
        {
            var basket = _basketRepository.GetBasketById(Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8"));
            basket.GameBaskets.Clear();
            _gameBasketRepository.Save();
        }

    }
}
