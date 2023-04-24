using GameShopBack.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace GameShopBack.DataAccess.EntityFramework
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Game> Games{ get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<GameBasket> GameBaskets { get; set; }
    }
}
