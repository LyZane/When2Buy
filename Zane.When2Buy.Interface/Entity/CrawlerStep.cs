using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy
{
    public class CrawlerStep
    {
        public PublicEnum.GoodsSource GoodsSource { get; private set; }
        public string StandardUrl { get;private set; }
        public Uri OriginalUrl { get; private set; }
        public string Key { get;private set; }

        public CrawlerStep(PublicEnum.GoodsSource goodsSource, Uri originalUrl,string stepKey, string standardUrl)
        {
            this.GoodsSource = goodsSource;
            this.StandardUrl = standardUrl;
            this.Key = stepKey;
            this.OriginalUrl = originalUrl;
        }
    }
}
