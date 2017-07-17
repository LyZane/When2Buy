using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.SQLiteStorage
{
    internal static class Extensions_ConvertType
    {
        internal static When2Buy.CrawlTask ToIEntity(this CrawlTask m)
        {
            if (m==null)
            {
                return null;
            }
            return new When2Buy.CrawlTask(m.GoodsSource, new Uri(m.OriginalUrl), m.Key, m.StandardUrl);
        }

        internal static CrawlTask ToDBEntity(this When2Buy.CrawlTask m)
        {
            if (m==null)
            {
                return null;
            }
            return new CrawlTask() { GoodsSource = m.GoodsSource, Key = m.Key, OriginalUrl = m.OriginalUrl.AbsoluteUri, StandardUrl=m.StandardUrl };
        }

        internal static Goods_Current[] GetCurrentGoodsList(When2Buy.PageResult result)
        {
            return result.GoodsList.Select(a => new Goods_Current() { GoodsKey = a.GoodsKey, GoodsSource = a.GoodsSource, InsertTime = DateTime.Now, Name = a.Name, Price = a.Price, Specification = a.Specification, TaskKey = result.TaskKey, UnitPrice = a.UnitPrice, Url = a.Uri.AbsoluteUri }).ToArray();
        }
        internal static Goods_History[] GetHistoryGoodsList(When2Buy.PageResult result)
        {
            return result.GoodsList.Select(a => new Goods_History() { GoodsKey = a.GoodsKey, GoodsSource = a.GoodsSource, InsertTime = DateTime.Now, Name = a.Name, Price = a.Price, Specification = a.Specification, TaskKey = result.TaskKey, UnitPrice = a.UnitPrice, Url = a.Uri.AbsoluteUri }).ToArray();
        }

        internal static When2Buy.PageResult ToIEntity(this IEnumerable<Goods_Current> goodsList)
        {
            if (goodsList == null||goodsList.Count()<1)
            {
                return null;
            }
            return new PageResult() { TaskKey=goodsList.First().TaskKey,  CrawlerTime = goodsList.First().UpdateTime, GoodsList = goodsList.Select(a=>a.ToIEntity()).ToArray() };
        }
        internal static When2Buy.PageResult ToIEntity(this IEnumerable<Goods_History> goodsList)
        {
            if (goodsList == null || goodsList.Count() < 1)
            {
                return null;
            }
            return new PageResult() { TaskKey = goodsList.First().TaskKey, CrawlerTime = goodsList.First().InsertTime, GoodsList = goodsList.Select(a => a.ToIEntity()).ToArray() };
        }

        internal static When2Buy.GoodsEntity ToIEntity(this Goods_Current g)
        {
            return new GoodsEntity() { GoodsKey = g.GoodsKey, GoodsSource = g.GoodsSource, Name = g.Name, Price = g.Price, Specification = g.Specification, UnitPrice = g.UnitPrice, Uri = new Uri(g.Url) };
        }

        internal static When2Buy.GoodsEntity ToIEntity(this Goods_History g)
        {
            return new GoodsEntity() { GoodsKey = g.GoodsKey, GoodsSource = g.GoodsSource, Name = g.Name, Price = g.Price, Specification = g.Specification, UnitPrice = g.UnitPrice, Uri = new Uri(g.Url) };
        }
    }
}
