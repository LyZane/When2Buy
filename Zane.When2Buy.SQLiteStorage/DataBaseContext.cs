using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zane.When2Buy.SQLiteStorage
{
    internal class DataBaseContext: DbContext
    {
        internal DataBaseContext(string connectionStringName) : base("name="+connectionStringName){ }
        public DbSet<CrawlTask> CrawlTasks { get; set; }
        public DbSet<Goods_Current> CurrentGoodsList { get; set; }
        public DbSet<Goods_History> HistoryGoodsList { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var config_CrawlTask = modelBuilder.Entity<CrawlTask>();
            config_CrawlTask.HasKey(a => a.Key);

            var config_CurrentGoodsList = modelBuilder.Entity<Goods_Current>();
            config_CurrentGoodsList.HasKey(a => a.GoodsKey);

            var config_HistoryGoodsList = modelBuilder.Entity<Goods_History>();
            config_HistoryGoodsList.HasKey(a => a.ViewKey);

            
        }
    }
}
