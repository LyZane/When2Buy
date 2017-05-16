using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zane.When2Buy.Crawler
{
    /// <summary>
    /// 后台线程，自动抓取当天数据。
    /// </summary>
    internal static class Worker
    {
        static bool IsRunning = false;
        static Thread _Worker = new Thread(Core);
        
        internal static void Run()
        {
            if (IsRunning)
            {
                throw new MethodAccessException("Worker is running.");
            }
            IsRunning = true;
            _Worker.Start();
        }

        private static void Core()
        {
            while (true)
            {
                //foreach (var geo in Service.GeoList)
                //{
                //    try
                //    {
                //        Service.Get(geo);
                //    }
                //    catch (Exception ex)
                //    {
                //        //Log
                //    }
                //}
                Task.Delay(TimeSpan.FromMinutes(10)).Wait();
            }
        }
    }
}
