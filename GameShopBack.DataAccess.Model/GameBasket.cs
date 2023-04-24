using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopBack.DataAccess.Model
{
    public class GameBasket : Entity
    {
        public int Price { get; set; }
        public int ProductCount { get; set; }
        public Guid BasketId { get; set; }
        public Basket Basket { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}
