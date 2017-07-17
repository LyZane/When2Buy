using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy
{
    public class CrawlTask
    {
        public GoodsSource GoodsSource { get; private set; }
        public string StandardUrl { get;private set; }
        public Uri OriginalUrl { get; private set; }
        public string Key { get;private set; }

        public CrawlTask(GoodsSource goodsSource, Uri originalUrl,string key, string standardUrl)
        {
            this.GoodsSource = goodsSource;
            this.StandardUrl = standardUrl;
            this.Key = key;
            this.OriginalUrl = originalUrl;
        }
    }
}
