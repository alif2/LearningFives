using System.Threading.Tasks;
using DataAccessors;
using DataAccessors.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearningFivesTests.DataAccessors
{
    [TestClass]
    public class TeamsDataAccessorTest
    {
        private TeamsDataAccessor _teamsDataAccessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _teamsDataAccessor = new TeamsDataAccessor();
            Assert.IsNotNull(_teamsDataAccessor);
        }

        [TestMethod]
        public async Task GetAllStudentsAsyncTest()
        {
            var filter = new StudentFilterDM
            {
                RankTier = null,
                Server = null,
                StudentStatus = -1
            };

            var students = await _teamsDataAccessor.GetAllStudentsAsync(filter);
            foreach (var student in students)
            {
                Assert.IsTrue(student.StudentSignUpID >= 0);
                Assert.IsTrue(student.StudentStatus >= 0 && student.StudentStatus <= 1);
                Assert.IsTrue(student.SummonerInfoID >= 0);
                Assert.IsTrue(student.AvailabilityInfoID >= 0);
                Assert.IsFalse(string.IsNullOrEmpty(student.Languages));
                Assert.IsFalse(string.IsNullOrEmpty(student.PairedPlayers));
                Assert.IsFalse(string.IsNullOrEmpty(student.PlayerStrengths));
                Assert.IsFalse(string.IsNullOrEmpty(student.PlayerImprovement));
                Assert.IsFalse(string.IsNullOrEmpty(student.PlayerExpectations));
                Assert.IsTrue(student.CommitmentID >= 0);
                Assert.IsTrue(student.ToxicID >= 0);
                Assert.IsFalse(string.IsNullOrEmpty(student.SummonerInfo.SummonerName));
                Assert.IsFalse(string.IsNullOrEmpty(student.SummonerInfo.ServerName));
                Assert.IsTrue(student.SummonerInfo.Age > 0);
                Assert.IsFalse(string.IsNullOrEmpty(student.SummonerInfo.Email));
            }
        }
    }
}
