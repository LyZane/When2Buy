using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.When2Buy.Interface;

namespace Zane.When2Buy.Crawler
{
    public static class Service
    {
        static IPageModel[] PageModels = { new PageModel_Amazon() };
        static IStorage _Storage;
        static Service()
        {
            if (!GlobalConfiguration.IsRuning)
            {
                throw new MethodAccessException("Service initialize fail,please Startup Service with a Configuration.");
            }
            _Storage = GlobalConfiguration.CurrentConfiguration.Storage;
        }

        public static PageResult GetResult(string stepKey)
        {
            var result = _Storage.QueryPageResult(stepKey);
            if (result != null)
            {
                return result;
            }
            var step = _Storage.GetCrawlerStepByKey(stepKey);
            if (step == null)
            {
                throw new ArgumentException(nameof(stepKey));
            }
            var pageModel = QueryPageModel(step.OriginalUrl);
            result = pageModel.Crawler(step);
            result.Key = step.Key;
            _Storage.SavePageResult(result);
            return result;
        }

        private static IPageModel QueryPageModel(Uri uri)
        {
            foreach (var item in PageModels)
            {
                if (item.IsMatch(uri))
                {
                    return item;
                }
            }
            return null;
        }
        public static CrawlerStep CreateCrawlerStep(Uri uri)
        {
            var pageModel = QueryPageModel(uri);
            if (pageModel==null)
            {
                return null;
            }
            var step = pageModel.CreateCrawlerStep(uri);
            _Storage.SaveCrawlerStep(step);
            return step;
        }
    }
}
