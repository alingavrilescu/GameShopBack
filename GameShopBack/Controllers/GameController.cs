using GameShopBack.DataAccess.EntityFramework;
using GameShopBack.DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameShopBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameRepository _gameRepository;

        public GameController(GameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
            return this._gameRepository.GetAllGames();
        }

        [HttpGet("{category}")]
        public IEnumerable<Game> GetGamesByCategory(string category)
        {
            return this._gameRepository.GetGamesByCategory(category);
        }

        [HttpGet("byId/{id}")]
        public Game GetGameById(Guid id)
        {
            return this._gameRepository.GetGameById(id);
        }

        //public Game AddGameToBasket(Guid id)
        //{
        //    var game = _gameRepository.GetGameById(id);
        //    var basket = _basketRepository.GetBasketById("asdasdasda");
        //    if (basket.Games.Any(g=>g.id==id))
        //    {

        //    }
        //}
    }
}
