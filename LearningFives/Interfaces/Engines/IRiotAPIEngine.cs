using DataModels.Teams;

namespace Interfaces.Engines
{
    public interface IRiotApiEngine
    {
        SummonerInfoDM GetSummonerByName(string summonerName, string server);
        void UpdateRiotApiSummoner(string summonerName, string server);
    }
}