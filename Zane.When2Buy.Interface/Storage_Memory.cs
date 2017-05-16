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
        Dictionary<string, CrawlerStep> CrawlerStepList = new Dictionary<string, CrawlerStep>();
        public CrawlerStep GetCrawlerStep()
        {
            throw new NotImplementedException();
        }

        public CrawlerStep GetCrawlerStepById(string id)
        {
            throw new NotImplementedException();
        }

        public CrawlerStep GetCrawlerStepByKey(string key)
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

        public void SaveCrawlerStep(CrawlerStep step)
        {
            CrawlerStepList[step.Key] = step;
        }

        public void SavePageResult(PageResult result)
        {
            PageResultList[result.Key] = result;
        }
    }
}
