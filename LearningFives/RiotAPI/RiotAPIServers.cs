using System;
using System.Collections.Generic;
using System.Linq;
using RiotAPI.Enums;

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
            var regions = Enum.GetValues(typeof(RiotApiEnums.Regions));
            var platforms = Enum.GetValues(typeof(RiotApiEnums.Platforms));
            for (var i = 0; i < regions.Length; i++)
            {
                string platformId = null;
                if (i <= platforms.Length)
                {
                    platformId = regions.GetValue(i).ToString();
                }

                if (regions.GetValue(i).Equals(region))
                {
                    return new RiotApiServers
                    {
                        Region = regions.GetValue(i).ToString(),
                        PlatformId = platformId,
                        HostName = regions.GetValue(i).ToString().ToLower() + ".api.pvp.net"
                    };
                }
            }
            return null;
        }

        public static IEnumerable<RiotApiServers> GetAllServers()
        {
            var allServers = new List<RiotApiServers>();

            var regions = (string[])Enum.GetValues(typeof(RiotApiEnums.Regions));
            var platforms = (string[])Enum.GetValues(typeof(RiotApiEnums.Platforms));
            for (var i = 0; i < regions.Length; i++)
            {
                string platformId = null;
                if (i <= platforms.Length)
                {
                    platformId = regions[i];
                }

                allServers.Add(new RiotApiServers
                {
                    Region = regions[i],
                    PlatformId = platformId,
                    HostName = regions[i].ToLower() + ".api.pvp.net"
                });
            }

            return allServers;
        }
    }
}