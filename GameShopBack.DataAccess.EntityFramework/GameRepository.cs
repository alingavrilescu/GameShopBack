using GameShopBack.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopBack.DataAccess.EntityFramework
{
    public class GameRepository
    {
        protected readonly GameContext _dbcontext;
        public GameRepository(GameContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _dbcontext.Set<Game>().ToList();
        }

        public IEnumerable<Game> GetGamesByCategory(string category)
        {
            return _dbcontext.Set<Game>().Where(c => c.Category == category).ToList();

        }

        public Game GetGameById(Guid id)
        {
            var gameToReturn = _dbcontext.Set<Game>().Where(g => g.id == id).FirstOrDefault();
            if (gameToReturn == null)
            {
                throw new KeyNotFoundException("Game was not found");
            }
            return gameToReturn;
        }
    }
}
