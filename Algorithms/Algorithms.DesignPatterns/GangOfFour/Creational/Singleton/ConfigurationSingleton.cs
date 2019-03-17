using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Singleton
{
    public sealed class ConfigurationSingleton
    {
        public string DbConnectionString { get; set; }
        public string EnvironmentName { get; set; }

        private static ConfigurationSingleton Instance {get; set; }

        private ConfigurationSingleton ()
        {
        }

        public static ConfigurationSingleton GetInstance ()
        {
            lock (typeof(ConfigurationSingleton))
            {
                if (Instance == null)
                    Instance = new ConfigurationSingleton();
            }

            return Instance;
        }
    }
}
