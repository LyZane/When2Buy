using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Interface.Storage_SQLite
{
    internal class CrawlerTask
    {
        public PublicEnum.GoodsSource GoodsSource { get; private set; }
        public string StandardUrl { get; private set; }
        public Uri OriginalUrl { get; private set; }
        public string Key { get; private set; }
    }
}
