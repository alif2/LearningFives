﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using DataAccessors;

namespace RiotAPITests
{
    [TestClass]
    public class RiotApiTests
    {
        [TestMethod]
        public async Task CallTest()
        {
            var test = new RiotApiDataAccessor();
            test.GetSummonerByName("Dyrus", "NA");

            //var test = new RiotApiDataAccessor();
            //test.UpdateRiotApiSummoner("Tsundraki", "NA");


            /*var tda = new TeamsDataAccessor();
            var one = await tda.GetAllStudentsAsync(new StudentFilterDM
            {
                PageNumber = 1,
                PageSize = 20,
                RankTier = null,
                Server = null,
                StudentStatus = -1
            });

            var two = await tda.GetAllCoachesAsync(new CoachFilterDM
            {
                PageNumber = 1,
                PageSize = 20,
                RankTier = null,
                Server = null,
                CoachStatus = -1
            });*/
        }
    }
}