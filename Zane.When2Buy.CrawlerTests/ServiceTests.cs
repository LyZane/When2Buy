using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zane.When2Buy.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.When2Buy.Interface;

namespace Zane.When2Buy.Crawler.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        public ServiceTests()
        {
            //new Zane.When2Buy.SQLiteStorage.Service("SqliteTest")
            Zane.When2Buy.Crawler.GlobalConfiguration.CurrentConfiguration.SetStorage(new Storage_Memory()).Startup();
        }

        [TestMethod()]
        public void CreateCrawlerStepTest()
        {
            var step = Zane.When2Buy.Crawler.Service.CreateCrawlerStep(new Uri("https://www.amazon.cn/gp/product/B01M62767W/ref=oh_aui_detailpage_o00_s00?ie=UTF8&psc=1"));
            var result = Zane.When2Buy.Crawler.Service.GetResult(step.Key);
        }
    }
}