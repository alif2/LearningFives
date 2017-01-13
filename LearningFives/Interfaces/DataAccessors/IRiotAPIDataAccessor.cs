using DataModels.Teams;

namespace Interfaces.DataAccessors
{
    public interface IRiotApiDataAccessor
    {
        SummonerInfoDM GetSummonerByName(string summonerName, string server);
        void UpdateRiotApiSummoner(string summonerName, string server);
    }
}