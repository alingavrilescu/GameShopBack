using GameShopBack.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopBack.DataAccess.EntityFramework
{
    public class BasketRepository
    {
        protected readonly GameContext _dbcontext;
        public BasketRepository(GameContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Basket GetBasketById(Guid id)
        {
            return _dbcontext.Set<Basket>().Include(g => g.GameBaskets).ThenInclude(x=>x.Game).Where(g => g.id == id).FirstOrDefault();
        }
    }
}
