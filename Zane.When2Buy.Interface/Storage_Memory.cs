using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Interface
{
    public class Storage_Memory : IStorage
    {

        Dictionary<string, PageResult> PageResultList = new Dictionary<string, PageResult>();
        Dictionary<string, CrawlTask> CrawlerStepList = new Dictionary<string, CrawlTask>();
        public CrawlTask GetCrawlerStep()
        {
            throw new NotImplementedException();
        }

        public CrawlTask GetCrawlerStepById(string id)
        {
            throw new NotImplementedException();
        }

        public CrawlTask GetCrawlerStepByKey(string key)
        {
            if (CrawlerStepList.ContainsKey(key))
            {
                return CrawlerStepList[key];
            }
            return null;
        }

        public PageResult QueryPageResult(string key)
        {
            if (PageResultList.ContainsKey(key))
            {
                return PageResultList[key];
            }
            return null;
        }

        public void AddCrawlTask(CrawlTask step)
        {
            CrawlerStepList[step.Key] = step;
        }

        public void AddOrUpdatePageResult(PageResult result)
        {
            PageResultList[result.TaskKey] = result;
        }
    }
}
