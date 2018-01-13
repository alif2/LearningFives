using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotAPI;
using RiotAPI.Enums;

namespace RiotAPITests
{
    [TestClass]
    public class RiotApiServersTests
    {
        [TestMethod]
        public void GetRegionByNameBrazil()
        {
            var region = RiotApiServers.GetRegionByName("BR");
            Assert.AreEqual(RiotApiEnums.Regions.BR, region);
        }

        [TestMethod]
        public void GetRegionByNameEuropeNordicAndEast()
        {
            var region = RiotApiServers.GetRegionByName("EUNE");
            Assert.AreEqual(RiotApiEnums.Regions.EUNE, region);
        }

        [TestMethod]
        public void GetRegionByNameEuropeWest()
        {
            var region = RiotApiServers.GetRegionByName("EUW");
            Assert.AreEqual(RiotApiEnums.Regions.EUW, region);
        }

        [TestMethod]
        public void GetRegionByNameJapan()
        {
            var region = RiotApiServers.GetRegionByName("JP");
            Assert.AreEqual(RiotApiEnums.Regions.JP, region);
        }

        [TestMethod]
        public void GetRegionByNameKorea()
        {
            var region = RiotApiServers.GetRegionByName("KR");
            Assert.AreEqual(RiotApiEnums.Regions.KR, region);
        }

        [TestMethod]
        public void GetRegionByNameLatinAmericaNorth()
        {
            var region = RiotApiServers.GetRegionByName("LAN");
            Assert.AreEqual(RiotApiEnums.Regions.LAN, region);
        }

        [TestMethod]
        public void GetRegionByNameLatinAmericaSouth()
        {
            var region = RiotApiServers.GetRegionByName("LAS");
            Assert.AreEqual(RiotApiEnums.Regions.LAS, region);
        }

        [TestMethod]
        public void GetRegionByNameOceania()
        {
            var region = RiotApiServers.GetRegionByName("OCE");
            Assert.AreEqual(RiotApiEnums.Regions.OCE, region);
        }

        [TestMethod]
        public void GetRegionByNameTurkey()
        {
            var region = RiotApiServers.GetRegionByName("TR");
            Assert.AreEqual(RiotApiEnums.Regions.TR, region);
        }

        [TestMethod]
        public void GetRegionByNameRussia()
        {
            var region = RiotApiServers.GetRegionByName("RU");
            Assert.AreEqual(RiotApiEnums.Regions.RU, region);
        }

        [TestMethod]
        public void GetRegionByNamePublicTestEnvironment()
        {
            var region = RiotApiServers.GetRegionByName("PBE");
            Assert.AreEqual(RiotApiEnums.Regions.PBE, region);
        }

        [TestMethod]
        public void GetRegionByNameGlobal()
        {
            var region = RiotApiServers.GetRegionByName("GLOBAL");
            Assert.AreEqual(RiotApiEnums.Regions.GLOBAL, region);
        }

        [TestMethod]
        public void GetServerByRegionBrazil()
        {
            var br = RiotApiEnums.Regions.BR;
            var server = RiotApiServers.GetServerByRegion(br);
            Assert.AreEqual(br.ToString(), server.Region);
            Assert.AreEqual("BR1", server.PlatformId);
            Assert.AreEqual("br1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionEuropeNordicAndEast()
        {
            var eune = RiotApiEnums.Regions.EUNE;
            var server = RiotApiServers.GetServerByRegion(eune);
            Assert.AreEqual(eune.ToString(), server.Region);
            Assert.AreEqual("EUN1", server.PlatformId);
            Assert.AreEqual("eun1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionEuropeWest()
        {
            var euw = RiotApiEnums.Regions.EUW;
            var server = RiotApiServers.GetServerByRegion(euw);
            Assert.AreEqual(euw.ToString(), server.Region);
            Assert.AreEqual("EUW1", server.PlatformId);
            Assert.AreEqual("euw1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionJapan()
        {
            var jp = RiotApiEnums.Regions.JP;
            var server = RiotApiServers.GetServerByRegion(jp);
            Assert.AreEqual(jp.ToString(), server.Region);
            Assert.AreEqual("JP1", server.PlatformId);
            Assert.AreEqual("jp1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionKorea()
        {
            var kr = RiotApiEnums.Regions.KR;
            var server = RiotApiServers.GetServerByRegion(kr);
            Assert.AreEqual(kr.ToString(), server.Region);
            Assert.AreEqual("KR", server.PlatformId);
            Assert.AreEqual("kr.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionLatinAmericaNorth()
        {
            var lan = RiotApiEnums.Regions.LAN;
            var server = RiotApiServers.GetServerByRegion(lan);
            Assert.AreEqual(lan.ToString(), server.Region);
            Assert.AreEqual("LA1", server.PlatformId);
            Assert.AreEqual("la1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionLatinAmericaSouth()
        {
            var las = RiotApiEnums.Regions.LAS;
            var server = RiotApiServers.GetServerByRegion(las);
            Assert.AreEqual(las.ToString(), server.Region);
            Assert.AreEqual("LA2", server.PlatformId);
            Assert.AreEqual("la2.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionNorthAmerica()
        {
            var na = RiotApiEnums.Regions.NA;
            var server = RiotApiServers.GetServerByRegion(na);
            Assert.AreEqual(na.ToString(), server.Region);
            Assert.AreEqual("NA1", server.PlatformId);
            Assert.AreEqual("na1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionOceania()
        {
            var oce = RiotApiEnums.Regions.OCE;
            var server = RiotApiServers.GetServerByRegion(oce);
            Assert.AreEqual(oce.ToString(), server.Region);
            Assert.AreEqual("OC1", server.PlatformId);
            Assert.AreEqual("oc1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionTurkey()
        {
            var tr = RiotApiEnums.Regions.TR;
            var server = RiotApiServers.GetServerByRegion(tr);
            Assert.AreEqual(tr.ToString(), server.Region);
            Assert.AreEqual("TR1", server.PlatformId);
            Assert.AreEqual("tr1.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionRussia()
        {
            var ru = RiotApiEnums.Regions.RU;
            var server = RiotApiServers.GetServerByRegion(ru);
            Assert.AreEqual(ru.ToString(), server.Region);
            Assert.AreEqual("RU", server.PlatformId);
            Assert.AreEqual("ru.api.riotgames.com", server.HostName);
        }

        [TestMethod]
        public void GetServerByRegionPublicTestEnvrionment()
        {
            var pbe = RiotApiEnums.Regions.PBE;
            var server = RiotApiServers.GetServerByRegion(pbe);
            Assert.AreEqual(pbe.ToString(), server.Region);
            Assert.AreEqual("PBE1", server.PlatformId);
            Assert.AreEqual("pbe1.api.riotgames.com", server.HostName);
        }
    }
}