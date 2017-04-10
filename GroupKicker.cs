using Rocket.Core.Plugins;
using Rocket.Unturned;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupKicker
{
    public class GroupKicker : RocketPlugin<Configuration>
    {
        public bool Added = false;
        public GroupKicker Instance;
        protected override void Load()
        {
            Instance = this;
            base.Load();
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            foreach(var id in Instance.Configuration.Instance.Groups)
            {
                if(id == player.SteamGroupID)
                {
                    Added = true;
                }
            }
            if(Added == false)
            {
                Provider.kick(player.CSteamID, "");
            }
        }
    }
}
