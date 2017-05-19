using RiotAPI;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessors
{
    public class RiotApiDataAccessor
    {
        public SummonerInfo GetSummonerByName(string summonerName, string server)
        {
            using (var context = new LearningFivesEntities())
            {
                var summonerInfo = context.SummonerInfoes.First(summoner => summoner.SummonerName == summonerName && summoner.ServerName == server);
                if (summonerInfo == null) return null;
                
                if (summonerInfo.RiotAPISummoners.Count < 1)
                {
                    UpdateRiotApiSummoner(summonerName, server);
                    summonerInfo = context.SummonerInfoes.First(summoner => summoner.SummonerName == summonerName && summoner.ServerName == server);
                }
                
                return summonerInfo;
            }
        }

        public void UpdateRiotApiSummoner(string summonerName, string server)
        {
            using (var context = new LearningFivesEntities())
            {
                var summonerInfo = context.SummonerInfoes.First(summoner => summoner.SummonerName == summonerName && summoner.ServerName == server);
                if (summonerInfo == null) return;

                var riotApiServer = RiotApiServers.GetRegionByName(server);
                var riotApiSummoner = RiotApi.GetSummonerByName(summonerName, riotApiServer);
                var riotApiLeague = RiotApi.GetLeagueEntriesBySummonerId(riotApiSummoner.Id, riotApiServer);

                var newLeagues = new List<RiotAPILeague>();
                foreach (var league in riotApiLeague)
                {
                    var leagueEntry = league.Entries.First();

                    newLeagues.Add(new RiotAPILeague
                    {
                        LeagueName = league.Name,
                        QueueType = league.Queue,
                        Tier = league.Tier.ToString(),
                        RiotAPILeagueEntries = new List<RiotAPILeagueEntry>
                        {
                            new RiotAPILeagueEntry
                            {
                                Division = leagueEntry.Division,
                                IsFreshBlood = leagueEntry.IsFreshBlood,
                                IsHotStreak = leagueEntry.IsHotStreak,
                                IsInactive = leagueEntry.IsInactive,
                                IsVeteran = leagueEntry.IsVeteran,
                                LeaguePoints = leagueEntry.LeaguePoints,
                                Losses = leagueEntry.Losses,
                                Wins = leagueEntry.Wins
                            }
                        }
                    });
                }

                summonerInfo.RiotAPISummoners.Clear();
                summonerInfo.RiotAPISummoners.Add(new RiotAPISummoner
                {
                    RiotAPISummonerID = riotApiSummoner.Id,
                    ProfileIconID = riotApiSummoner.ProfileIconId,
                    RevisionDate = riotApiSummoner.RevisionDate,
                    SummonerLevel = riotApiSummoner.SummonerLevel,
                    RiotAPILeagues = newLeagues
                });

                context.SaveChanges();
            }
        }
    }
}