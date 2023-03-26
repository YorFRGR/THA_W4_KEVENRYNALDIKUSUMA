using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_W4_KEVENRYNALDIKUSUMA_0706022210029
{
    internal class Team
    {
        public string teamname { get; set; }
        public string teamcountry { get; set; }
        public string teamcity { get; set; }

        public List<Player> players = new List<Player>();
    }
    class Player
    {
        public string playername { get; set; }
        public string playernumber { get; set; }
        public string playerpos { get; set; }
    }
}
