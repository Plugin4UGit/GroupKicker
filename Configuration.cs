using Rocket.API;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace GroupKicker
{
    public class Configuration : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Group")]
        public List<CSteamID> Groups;
        public void LoadDefaults()
        {
            Groups = new List<CSteamID>()
            {
                new CSteamID(103582791439889796),
            };
        }
    }
}
