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
        private const string ApiKey = "RGAPI-3502b374-48e7-452f-9b9f-40551dc79ad0";

        public static RiotApiSummoner GetSummonerByName(string summonerName, RiotApiEnums.Regions region)
        {
            return GetSummonersByName(new List<string> {summonerName}, region).FirstOrDefault();
        }

        public static List<RiotApiSummoner> GetSummonersByName(List<string> summonerNames, RiotApiEnums.Regions region)
        {
            var path = GetPath(region) + "/v3/summoner/by-name/" + string.Join(",", summonerNames);
            return CallApi<Dictionary<string, RiotApiSummoner>>(path).Values.ToList();
        }

        public static RiotApiSummoner GetSummonerById(long summonerId, RiotApiEnums.Regions region)
        {
            return GetSummonersById(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static List<RiotApiSummoner> GetSummonersById(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var path = GetPath(region) + "/v3/summoner/" + string.Join(",", summonerIds);
            return CallApi<Dictionary<string, RiotApiSummoner>>(path).Values.ToList();
        }

        public static IEnumerable<RiotApiLeague> GetLeaguesBySummonerId(long summonerId, RiotApiEnums.Regions region)
        {
            return GetLeaguesBySummonerId(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static IEnumerable<IEnumerable<RiotApiLeague>> GetLeaguesBySummonerId(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var path = GetPath(region) + "/v3/league/by-summoner/" + string.Join(",", summonerIds);
            return CallApi<Dictionary<string, IEnumerable<RiotApiLeague>>>(path).Values.ToList();
        }

        public static IEnumerable<RiotApiLeague> GetLeagueEntriesBySummonerId(long summonerId, RiotApiEnums.Regions region)
        {
            return GetLeagueEntriesBySummonerId(new List<long> { summonerId }, region).FirstOrDefault();
        }

        public static IEnumerable<IEnumerable<RiotApiLeague>> GetLeagueEntriesBySummonerId(List<long> summonerIds, RiotApiEnums.Regions region)
        {
            var path = GetPath(region) + "/v3/league/by-summoner/" + string.Join(",", summonerIds) + "/entry";
            return CallApi<Dictionary<string, IEnumerable<RiotApiLeague>>>(path).Values.ToList();
        }

        private static string GetBaseUrl(RiotApiServers server)
        {
            return "https://" + server.HostName;
        }

        private static string GetBasePath(RiotApiServers server)
        {
            return "/api/lol/" + server.Region.ToLower();
        }

        private static string GetPath(RiotApiEnums.Regions region)
        {
            var server = RiotApiServers.GetServerByRegion(region);
            return GetBaseUrl(server) + GetBasePath(server);
        }

        private static T CallApi<T>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var completeUrl = $"{url}?api_key=" + ApiKey;
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