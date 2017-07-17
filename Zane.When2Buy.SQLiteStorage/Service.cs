using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.When2Buy.Interface;

namespace Zane.When2Buy.SQLiteStorage
{
    public class Service : IStorage
    {
        DataBaseContext _Context;
        public Service(string connectionStringName)
        {
            _Context = new DataBaseContext(connectionStringName);
        }

        public When2Buy.CrawlTask GetCrawlerStep()
        {
            throw new NotImplementedException();
        }

        public When2Buy.CrawlTask GetCrawlerStepById(string id)
        {
            throw new NotImplementedException();
        }

        public When2Buy.CrawlTask GetCrawlerStepByKey(string taskKey)
        {
            return _Context.CrawlTasks.FirstOrDefault(a => a.Key == taskKey).ToIEntity();
        }

        public When2Buy.PageResult QueryPageResult(string taskKey)
        {
            return _Context.CurrentGoodsList.Where(a => a.TaskKey == taskKey).ToIEntity();
        }

        public void AddCrawlTask(When2Buy.CrawlTask task)
        {
            if (_Context.CrawlTasks.FirstOrDefault(a => a.Key == task.Key) == null)
            {
                _Context.CrawlTasks.Add(task.ToDBEntity());
            }
        }

        public void AddOrUpdatePageResult(When2Buy.PageResult result)
        {
            throw new NotImplementedException();
        }
    }
}
