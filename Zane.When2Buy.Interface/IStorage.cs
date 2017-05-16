using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy.Interface
{
    public interface IStorage
    {
        CrawlerStep GetCrawlerStep();
        CrawlerStep GetCrawlerStepById(string id);
        CrawlerStep GetCrawlerStepByKey(string key);

        void SaveCrawlerStep(CrawlerStep step);

        void SavePageResult(PageResult result);

        PageResult QueryPageResult(string key);
    }
}
