using Rocket.API;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupKicker
{
    public class Configuration : IRocketPluginConfiguration
    {
        public List<CSteamID> Groups;
        public void LoadDefaults()
        {
            Groups = new List<CSteamID>()
            {
                new CSteamID(11111111111),
            };
        }
    }
}
