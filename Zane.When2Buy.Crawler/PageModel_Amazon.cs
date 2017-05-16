using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.Common.Extensions.Base;
using Zane.Common.WebBrowser;

namespace Zane.When2Buy.Crawler
{
    internal class PageModel_Amazon : IPageModel
    {
        internal override PublicEnum.GoodsSource GoodsSource => PublicEnum.GoodsSource.Amazon;

        protected override string GetPageKey(Uri uri)
        {
            return uri.AbsoluteUri.Match("(?<=www.amazon.cn/gp/product/)[0-9a-z]+");
        }

        protected override string StandardizeUrl(Uri uri)
        {
            return "https://www.amazon.cn/gp/product/" + uri.AbsoluteUri.Match("(?<=www.amazon.cn/gp/product/)[0-9a-z]+");
        }

        internal override PageResult Crawler(CrawlerStep step)
        {
            PageResult result = new PageResult();
            var response = Browser.DownloadString(step.OriginalUrl);
            if (response.Error!=null)
            {
                return null;
            }
            IHtmlDocument doc = new JumonyParser().Parse(response.PageSource);
            GoodsEntity g = new GoodsEntity();
            g.Name = doc.FindFirst("#productTitle").InnerText().Trim();
            g.Price = doc.FindFirst("#priceblock_ourprice").InnerText().ExtractPrice().Value;
            result.CrawlerTime = DateTime.Now;
            result.GoodsList = new GoodsEntity[]{ g };
            return result;
        }

        internal override bool IsMatch(Uri uri)
        {
            return uri.AbsoluteUri.IsMatch("www.amazon.cn/gp/product/[0-9a-z]+");
        }
    }
}
