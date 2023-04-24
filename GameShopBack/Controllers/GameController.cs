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

        [HttpPost]
        public Game AddGame(GameViewModel toAdd)
        {
            var game = new Game
            {
                Name = toAdd.Name,
                ImgUrl = toAdd.ImgUrl,
                Description = toAdd.Description,
                Category = toAdd.Category,
                Price = toAdd.Price,
                ProductCount = toAdd.ProductCount
            };
            return _gameRepository.AddGame(game);
        }
    }
}
