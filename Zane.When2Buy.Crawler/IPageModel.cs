using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.Common.WebBrowser;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy.Crawler
{
    internal abstract class IPageModel
    {
        public IWebBrowser Browser = new WebBrowser();
        internal abstract GoodsSource GoodsSource { get; }
        

        internal CrawlTask CreateCrawlerStep(Uri uri)
        {
            if (!IsMatch(uri))
            {
                throw new Exception("页面模型不匹配");
            }
            var result = new CrawlTask(this.GoodsSource, uri, GoodsSource+":"+GetPageKey(uri), StandardizeUrl(uri));
            return result;
        }
        internal abstract bool IsMatch(Uri uri);
        protected abstract string StandardizeUrl(Uri uri);
        protected abstract string GetPageKey(Uri uri);
        internal abstract PageResult Crawler(CrawlTask step);
    }
}
