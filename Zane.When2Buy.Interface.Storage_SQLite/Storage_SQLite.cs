using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Interface
{
    public class Storage_SQLite : IStorage
    {
        public CrawlerTask GetCrawlerStep()
        {
            throw new NotImplementedException();
        }

        public CrawlerTask GetCrawlerStepById(string id)
        {
            throw new NotImplementedException();
        }

        public CrawlerTask GetCrawlerStepByKey(string key)
        {
            throw new NotImplementedException();
        }

        public PageResult QueryPageResult(string key)
        {
            throw new NotImplementedException();
        }

        public void SaveCrawlerStep(CrawlerTask step)
        {
            throw new NotImplementedException();
        }

        public void SavePageResult(PageResult result)
        {
            throw new NotImplementedException();
        }
    }
}
