using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Interface.Storage_SQLite
{
    public class PageResult
    {
        public string TaskKey { get; set; }
        public GoodsEntity[] GoodsList { get; set; }
        public DateTime CrawlerTime { get; set; }
    }
}
