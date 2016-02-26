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

        public async Task<List<StudentSignUpVM>> GetAllStudentsAsync(int pageNumber, int pageSize)
        {
            return (await _adminEngine.GetAllStudentsAsync(pageNumber, pageSize))
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

        public async Task<List<CoachSignUpVM>> GetAllCoachesAsync(int pageNumber, int pageSize)
        {
            return (await _adminEngine.GetAllCoachesAsync(pageNumber, pageSize))
                .Select(coach => new CoachSignUpVM
                {
                    CoachStatus = coach.CoachStatus,
                    SummonerInfo = new SummonerSignUpVM
                    {
                        SummonerName = coach.SummonerInfo.SummonerName,
                        Server = coach.SummonerInfo.Server,
                        RankTier = coach.SummonerInfo.RankTier,
                        RankDivision = coach.SummonerInfo.RankDivision,
                        Age = coach.SummonerInfo.Age,
                        Email = coach.SummonerInfo.Email,
                        HasSlackAccount = coach.SummonerInfo.HasSlackAccount
                    },
                    InterestedBronze = coach.InterestedBronze,
                    InterestedSilver = coach.InterestedSilver,
                    InterestedGold = coach.InterestedGold,
                    InterestedPlat = coach.InterestedPlat,
                    InterestedDiamond = coach.InterestedDiamond,
                    WillingBronze = coach.WillingBronze,
                    WillingSilver = coach.WillingSilver,
                    WillingGold = coach.WillingGold,
                    WillingPlat = coach.WillingPlat,
                    WillingDiamond = coach.WillingDiamond,
                    AvailabilityInfo = new AvailabilitySignUpVM
                    {
                        MondayStart = coach.AvailabilityInfo.MondayStart,
                        MondayEnd = coach.AvailabilityInfo.MondayEnd,
                        TuesdayStart = coach.AvailabilityInfo.TuesdayStart,
                        TuesdayEnd = coach.AvailabilityInfo.TuesdayEnd,
                        WednesdayStart = coach.AvailabilityInfo.WednesdayStart,
                        WednesdayEnd = coach.AvailabilityInfo.WednesdayEnd,
                        ThursdayStart = coach.AvailabilityInfo.ThursdayStart,
                        ThursdayEnd = coach.AvailabilityInfo.ThursdayEnd,
                        FridayStart = coach.AvailabilityInfo.FridayStart,
                        FridayEnd = coach.AvailabilityInfo.FridayEnd,
                        SaturdayStart = coach.AvailabilityInfo.SaturdayStart,
                        SaturdayEnd = coach.AvailabilityInfo.SaturdayEnd,
                        SundayStart = coach.AvailabilityInfo.SundayStart,
                        SundayEnd = coach.AvailabilityInfo.SundayEnd
                    },
                    Languages = coach.Languages,
                    PairedPlayers = coach.PairedPlayers,
                    CoachingStyle = coach.CoachingStyle,
                    CoachingExperience = coach.CoachingExperience,
                    Commitment = new CommitmentSignUpVM
                    {
                        CommitmentLevel = coach.Commitment.CommitmentLevel,
                        SeriousnessLevel = coach.Commitment.SeriousnessLevel
                    },
                    Toxic = new ToxicSignUpVM
                    {
                        ToxicLevel = coach.Toxic.ToxicLevel,
                        HadLowPriorityPunish = coach.Toxic.HadLowPriorityPunish,
                        HadChatRestrictions = coach.Toxic.HadChatRestrictions,
                        HadRankedRestrictions = coach.Toxic.HadRankedRestrictions,
                        HadTemporaryBan = coach.Toxic.HadTemporaryBan,
                        HadPermanentBan = coach.Toxic.HadPermanentBan
                    },
                    MoreInformation = coach.MoreInformation,
                    EmailSignUp = coach.EmailSignUp
                }).ToList();
        }
    }
}