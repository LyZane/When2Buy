using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy.SQLiteStorage
{
    public class Goods_Current: GoodsEntity
    {
        public string Url { get; set; }
        public string TaskKey { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
