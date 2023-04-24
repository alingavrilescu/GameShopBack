using GameShopBack.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace GameShopBack.DataAccess.EntityFramework
{
    public class GameBasketRepository
    {
        protected readonly GameContext _dbcontext;
        public GameBasketRepository(GameContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<GameBasket> GetGameBasket()
        {
            return _dbcontext.Set<GameBasket>().Include(g => g.Game).ToList();
        }

        public void AddGameBasket(GameBasket toAdd)
        {
            _dbcontext.Set<GameBasket>().Add(toAdd);
        }

        public GameBasket GetGameBasketById(Guid id)
        {
            return _dbcontext.Set<GameBasket>().Include(g => g.Game).Where(g => g.id == id).FirstOrDefault();
        }

        public GameBasket GetGameBasketByGameId(Guid gameId)
        {
            return _dbcontext.Set<GameBasket>().Where(b => b.BasketId == Guid.Parse("f5cde334-f3bf-4188-82dc-0cfd25f97aa8") && b.GameId == gameId).FirstOrDefault();
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }
    }
}
