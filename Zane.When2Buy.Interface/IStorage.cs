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
        CrawlTask GetCrawlerStep();
        CrawlTask GetCrawlerStepById(string id);
        CrawlTask GetCrawlerStepByKey(string key);

        void AddCrawlTask(CrawlTask step);

        void AddOrUpdatePageResult(PageResult result);

        PageResult QueryPageResult(string key);
    }
}
