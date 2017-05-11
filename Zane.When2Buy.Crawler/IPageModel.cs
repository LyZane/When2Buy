using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.Crawler
{
    public abstract class IPageModel
    {
        internal bool IsMatch(string url)
        {
            return true;
        }
    }
}
