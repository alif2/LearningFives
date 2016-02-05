using Interfaces.Engines;
using Interfaces.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Managers
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminEngine _adminEngine;

        public AdminManager(IAdminEngine adminEngine)
        {
            _adminEngine = adminEngine;
        }

        public async Task<List<StudentSignUpVM>> GetAllStudentsAsync()
        {
            return (await _adminEngine.GetAllStudentsAsync())
                .Select(student => new StudentSignUpVM
            {
                    StudentStatus = student.StudentStatus,
                    SummonerInfo = new SummonerSignUpVM
                    {
                        SummonerName = student.SummonerInfo.SummonerName,
                        Server = student.SummonerInfo.Server,
                        RankTier = student.SummonerInfo.RankTier,
                        RankDivision = student.SummonerInfo.RankDivision,
                        Age = student.SummonerInfo.Age,
                        Email = student.SummonerInfo.Email,
                        HasSlackAccount = student.SummonerInfo.HasSlackAccount
                    },
                    RoleInfo = new RoleSignUpVM
                    {
                        PreferredRole = student.RoleInfo.PreferredRole,
                        TopLaneComfort = student.RoleInfo.TopLaneComfort,
                        JungleComfort = student.RoleInfo.JungleComfort,
                        MidComfort = student.RoleInfo.MidComfort,
                        MarksmanComfort = student.RoleInfo.MarksmanComfort,
                        SupportComfort = student.RoleInfo.SupportComfort
                    },
                    AvailabilityInfo = new AvailabilitySignUpVM
                    {
                        MondayStart = student.AvailabilityInfo.MondayStart,
                        MondayEnd = student.AvailabilityInfo.MondayEnd,
                        TuesdayStart = student.AvailabilityInfo.TuesdayStart,
                        TuesdayEnd = student.AvailabilityInfo.TuesdayEnd,
                        WednesdayStart = student.AvailabilityInfo.WednesdayStart,
                        WednesdayEnd = student.AvailabilityInfo.WednesdayEnd,
                        ThursdayStart = student.AvailabilityInfo.ThursdayStart,
                        ThursdayEnd = student.AvailabilityInfo.ThursdayEnd,
                        FridayStart = student.AvailabilityInfo.FridayStart,
                        FridayEnd = student.AvailabilityInfo.FridayEnd,
                        SaturdayStart = student.AvailabilityInfo.SaturdayStart,
                        SaturdayEnd = student.AvailabilityInfo.SaturdayEnd,
                        SundayStart = student.AvailabilityInfo.SundayStart,
                        SundayEnd = student.AvailabilityInfo.SundayEnd
                    },
                    Languages = student.Languages,
                    PairedPlayers = student.PairedPlayers,
                    PlayerStrengths = student.PlayerStrengths,
                    PlayerImprovement = student.PlayerImprovement,
                    PlayerExpectations = student.PlayerExpectations,
                    Commitment = new CommitmentSignUpVM
                    {
                        CommitmentLevel = student.Commitment.CommitmentLevel,
                        SeriousnessLevel = student.Commitment.SeriousnessLevel
                    },
                    Toxic = new ToxicSignUpVM
                    {
                        ToxicLevel = student.Toxic.ToxicLevel,
                        HadLowPriorityPunish = student.Toxic.HadLowPriorityPunish,
                        HadChatRestrictions = student.Toxic.HadChatRestrictions,
                        HadRankedRestrictions = student.Toxic.HadRankedRestrictions,
                        HadTemporaryBan = student.Toxic.HadTemporaryBan,
                        HadPermanentBan = student.Toxic.HadPermanentBan
                    },
                    MoreInformation = student.MoreInformation,
                    EmailSignUp = student.EmailSignUp
            }).ToList();
        }
    }
}