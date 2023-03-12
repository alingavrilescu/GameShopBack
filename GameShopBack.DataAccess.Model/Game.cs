using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopBack.DataAccess.Model
{
    public class Game: Entity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int ProductCount { get; set; }
    }
}
