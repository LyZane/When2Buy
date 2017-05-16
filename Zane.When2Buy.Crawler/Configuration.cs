using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.When2Buy.Interface;

namespace Zane.When2Buy.Crawler
{
    public class Configuration
    {
        public IStorage Storage{get;internal set;}
    }
}