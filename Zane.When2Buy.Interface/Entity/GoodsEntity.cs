using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zane.When2Buy.PublicEnum;

namespace Zane.When2Buy
{
    public class GoodsEntity
    {
        public string GoodsKey { get; set; }
        public Uri Uri { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// 单位均价：元/克、升、毫升……
        /// </summary>
        public double? UnitPrice { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public GoodsSource GoodsSource { get; set; }
        /// <summary>
        /// 视图唯一标识，当商品的名称或价格发生变化时，此标识会变更。
        /// </summary>
        public string ViewKey { get { return (Name + Price).GetHashCode().ToString(); } }
    }
}