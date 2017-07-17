using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy.SQLiteStorage
{
    internal class CrawlTask
    {
        public string Key { get; set; }
        public GoodsSource GoodsSource { get; set; }
        public string StandardUrl { get; set; }
        public string OriginalUrl { get; set; }
        public DateTime? LastSuccessTime { get; set; }
        public DateTime? LastCrawlerTime { get; set; }
    }
}
