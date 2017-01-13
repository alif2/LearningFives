using DataModels.Teams;
using Interfaces.DataAccessors;
using Interfaces.Engines;

namespace Engines
{
    public class RiotApiEngine : IRiotApiEngine
    {
        private readonly IRiotApiDataAccessor _riotApiDataAccessor;

        public RiotApiEngine(IRiotApiDataAccessor riotApiDataAccessor)
        {
            _riotApiDataAccessor = riotApiDataAccessor;
        }

        public SummonerInfoDM GetSummonerByName(string summonerName, string server)
        {
            return _riotApiDataAccessor.GetSummonerByName(summonerName, server);
        }

        public void UpdateRiotApiSummoner(string summonerName, string server)
        {
            _riotApiDataAccessor.UpdateRiotApiSummoner(summonerName, server);
        }
    }
}