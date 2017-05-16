using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zane.When2Buy.Interface;

namespace Zane.When2Buy.Crawler
{
    public static class GlobalConfiguration
    {
        public readonly static Configuration CurrentConfiguration = new Configuration();
        public static bool Initialized { get; private set; }
        public static bool IsRuning { get; private set; }
        public static void Startup(this Configuration config,bool immediatelyRun = false)
        {
            if (Initialized)
            {
                throw new MethodAccessException("Crawler is Initialized.");
            }
            Initialized = true;

            if (IsRuning)
            {
                throw new MethodAccessException("Crawler is runging.");
            }
            IsRuning = true;

            if (immediatelyRun)
            {
                Worker.Run();
            }
        }
        public static Configuration SetStorage(this Configuration config, IStorage storage)
        {
            CurrentConfiguration.Storage = storage;
            return config;
        }
    }

}
