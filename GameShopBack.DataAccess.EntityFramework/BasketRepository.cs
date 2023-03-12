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

    }
}
