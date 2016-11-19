using Newtonsoft.Json;
using RiotAPI.Enums;
using RiotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RiotAPI
{
    public class RiotApi
    {
        public static RiotApiSummonerDM GetSummonerByName(string summonerName, RiotApiEnums.Regions region)
        {
            return GetSummonersByName(new List<string> {summonerName}, region).FirstOrDefault();
        }

        public static List<RiotApiSummonerDM> GetSummonersByName(List<string> summonerNames, RiotApiEnums.Regions region)
        {
            var server = RiotApiServers.GetServerByRegion(region);
            var baseUrl = "https://" + server.HostName;
            var path = "/api/lol/" + server.Region.ToLower() + "/v1.4/summoner/by-name/" + string.Join(",", summonerNames);

            return CallApi<Dictionary<string, RiotApiSummonerDM>>(baseUrl, path).Values.ToList();
        }

        public static RiotApiSummonerDM GetSummonerById(long summonerId, RiotApiEnums.Regions region)
        {
            return GetSummonersById(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static List<RiotApiSummonerDM> GetSummonersById(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var server = RiotApiServers.GetServerByRegion(region);
            var baseUrl = "https://" + server.HostName;
            var path = "/api/lol/" + server.Region.ToLower() + "/v1.4/summoner/" + string.Join(",", summonerIds);

            return CallApi<Dictionary<string, RiotApiSummonerDM>>(baseUrl, path).Values.ToList();
        }

        public static IEnumerable<RiotApiLeagueDM> GetLeaguesBySummonerId(long summonerId, RiotApiEnums.Regions region)
        {
            return GetLeaguesBySummonerId(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static IEnumerable<IEnumerable<RiotApiLeagueDM>> GetLeaguesBySummonerId(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var server = RiotApiServers.GetServerByRegion(region);
            var baseUrl = "https://" + server.HostName;
            var path = "/api/lol/" + server.Region.ToLower() + "/v2.5/league/by-summoner/" + string.Join(",", summonerIds);

            return CallApi<Dictionary<string, IEnumerable<RiotApiLeagueDM>>>(baseUrl, path).Values.ToList();
        }

        public static IEnumerable<RiotApiLeagueDM> GetLeagueEntriesBySummonerId(long summonerId, RiotApiEnums.Regions region)
        {
            return GetLeagueEntriesBySummonerId(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static IEnumerable<IEnumerable<RiotApiLeagueDM>> GetLeagueEntriesBySummonerId(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var server = RiotApiServers.GetServerByRegion(region);
            var baseUrl = "https://" + server.HostName;
            var path = "/api/lol/" + server.Region.ToLower() + "/v2.5/league/by-summoner/" + string.Join(",", summonerIds) + "/entry";

            return CallApi<Dictionary<string, IEnumerable<RiotApiLeagueDM>>>(baseUrl, path).Values.ToList();
        }

        private static T CallApi<T>(string baseUrl, string path)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var completeUrl = $"{baseUrl}{path}?api_key=92b7b525-00fd-4bd4-8686-66eaff67fcd3";
                var response = httpClient.GetAsync(completeUrl).Result;

                if (!response.IsSuccessStatusCode)
                {
                    throw new JsonException(response.StatusCode + " - " + response.ReasonPhrase);
                }

                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}