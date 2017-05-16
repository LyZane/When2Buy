using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy
{
    public class GoodsEntity
    {
        public string GoodsKey { get; set; }
        public Uri Uri { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public GoodsSource GoodsSource { get; set; }
    }
}
