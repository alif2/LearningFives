using RiotAPI.Enums;
using System;
using System.Linq;

namespace RiotAPI
{
    public class RiotApiServers
    {
        public string Region { get; private set; }
        public string PlatformId { get; private set; }
        public string HostName { get; private set; }

        public static RiotApiEnums.Regions GetRegionByName(string serverName)
        {
            var regions = Enum.GetValues(typeof(RiotApiEnums.Regions));
            return regions.Cast<object>().Where(region => region.ToString().Equals(serverName)).Cast<RiotApiEnums.Regions>().FirstOrDefault();
        }

        public static RiotApiServers GetServerByRegion(RiotApiEnums.Regions region)
        {
            if (region == RiotApiEnums.Regions.GLOBAL)
                return new RiotApiServers
                {
                    Region = region.ToString()
                };

            var regions = Enum.GetValues(typeof(RiotApiEnums.Regions));
            var platforms = Enum.GetValues(typeof(RiotApiEnums.Platforms));
            for (var i = 0; i < regions.Length; i++)
            {
                if (!regions.GetValue(i).Equals(region))
                    continue;

                string platformId = null;
                if (i <= platforms.Length)
                {
                    platformId = platforms.GetValue(i).ToString();
                }

                return new RiotApiServers
                {
                    Region = regions.GetValue(i).ToString(),
                    PlatformId = platformId,
                    HostName = platformId?.ToLower() + ".api.riotgames.com"
                };
            }
            return null;
        }
    }
}