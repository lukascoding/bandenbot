using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace bandenbot
{
    public class Config
    {
        private const string ConfigFileName = "./config.json";
        public Bot Bot { get; set; }

        public static Config GetConfig()
        {
            var configContent = File.ReadAllText(ConfigFileName);
            return JsonConvert.DeserializeObject<Config>(configContent);
        }
    }

    public class Bot
    {
        public string Token { get; set; }
    }
}