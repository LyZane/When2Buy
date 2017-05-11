using Ivony.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Crawler
{
    internal class PageEntity
    {
        public string Url { get; set; }
        public IHtmlDocument Document{ get; set; }
    }
}
