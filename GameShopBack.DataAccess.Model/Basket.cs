using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopBack.DataAccess.Model
{
    public class Basket : Entity
    {
        public ICollection<GameBasket> GameBaskets { get; set; }
    }
}
