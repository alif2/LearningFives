using DataModels.SignUp;
using Interfaces.Engines;
using Interfaces.Managers;
using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Managers
{
    public class SignUpManager : ISignUpManager
    {
        private readonly ISignUpEngine _signUpEngine;

        public SignUpManager(ISignUpEngine signUpEngine)
        {
            _signUpEngine = signUpEngine;
        }

        public async Task<bool> RegisterStudent(StudentSignUpVM studentSignUp)
        {
            return await _signUpEngine.RegisterStudent(new StudentSignUpDM
            {
                StudentStatus = studentSignUp.StudentStatus,
                SummonerInfo = new SummonerSignUpDM
                {
                    SummonerName = studentSignUp.SummonerInfo.SummonerName,
                    Server = studentSignUp.SummonerInfo.Server,
                    Age = studentSignUp.SummonerInfo.Age,
                    Email = studentSignUp.SummonerInfo.Email,
                },
                RoleInfo = new RoleSignUpDM
                {
                    PreferredRole = studentSignUp.RoleInfo.PreferredRole,
                    TopLane = studentSignUp.RoleInfo.TopLane,
                    Jungle = studentSignUp.RoleInfo.Jungle,
                    MidLane = studentSignUp.RoleInfo.MidLane,
                    Adc = studentSignUp.RoleInfo.Adc,
                    Support = studentSignUp.RoleInfo.Support
                },
                AvailabilityInfo = new AvailabilitySignUpDM
                {
                    MondayStart = studentSignUp.AvailabilityInfo.MondayStart,
                    MondayEnd = studentSignUp.AvailabilityInfo.MondayEnd,
                    TuesdayStart = studentSignUp.AvailabilityInfo.TuesdayStart,
                    TuesdayEnd = studentSignUp.AvailabilityInfo.TuesdayEnd,
                    WednesdayStart = studentSignUp.AvailabilityInfo.WednesdayStart,
                    WednesdayEnd = studentSignUp.AvailabilityInfo.WednesdayEnd,
                    ThursdayStart = studentSignUp.AvailabilityInfo.ThursdayStart,
                    ThursdayEnd = studentSignUp.AvailabilityInfo.ThursdayEnd,
                    FridayStart = studentSignUp.AvailabilityInfo.FridayStart,
                    FridayEnd = studentSignUp.AvailabilityInfo.FridayEnd,
                    SaturdayStart = studentSignUp.AvailabilityInfo.SaturdayStart,
                    SaturdayEnd = studentSignUp.AvailabilityInfo.SaturdayEnd,
                    SundayStart = studentSignUp.AvailabilityInfo.SundayStart,
                    SundayEnd = studentSignUp.AvailabilityInfo.SundayEnd
                },
                Languages = studentSignUp.Languages,
                PairedPlayers = studentSignUp.PairedPlayers,
                PlayerStrengths = studentSignUp.PlayerStrengths,
                PlayerImprovement = studentSignUp.PlayerImprovement,
                PlayerExpectations = studentSignUp.PlayerExpectations,
                Commitment = new CommitmentSignUpDM
                {
                    CommitmentLevel = studentSignUp.Commitment.CommitmentLevel,
                    SeriousnessLevel = studentSignUp.Commitment.SeriousnessLevel
                },
                Toxic = new ToxicSignUpDM
                {
                    ToxicLevel = studentSignUp.Toxic.ToxicLevel,
                    HadLowPriorityPunish = studentSignUp.Toxic.HadLowPriorityPunish,
                    HadChatRestrictions = studentSignUp.Toxic.HadChatRestrictions,
                    HadRankedRestrictions = studentSignUp.Toxic.HadRankedRestrictions,
                    HadTemporaryBan = studentSignUp.Toxic.HadTemporaryBan,
                    HadPermanentBan = studentSignUp.Toxic.HadPermanentBan
                },
                MoreInformation = studentSignUp.MoreInformation,
                EmailSignUp = studentSignUp.EmailSignUp
            });
        }

        public async Task<bool> RegisterCoach(CoachSignUpVM coachSignUp)
        {
            return await _signUpEngine.RegisterCoach(new CoachSignUpDM
            {
                CoachStatus = coachSignUp.CoachStatus,
                SummonerInfo = new SummonerSignUpDM
                {
                    SummonerName = coachSignUp.SummonerInfo.SummonerName,
                    Server = coachSignUp.SummonerInfo.Server,
                    Age = coachSignUp.SummonerInfo.Age,
                    Email = coachSignUp.SummonerInfo.Email
                },
                InterestedBronze = coachSignUp.InterestedBronze,
                InterestedSilver = coachSignUp.InterestedSilver,
                InterestedGold = coachSignUp.InterestedGold,
                InterestedPlat = coachSignUp.InterestedPlat,
                InterestedDiamond = coachSignUp.InterestedDiamond,

                WillingBronze = coachSignUp.WillingBronze,
                WillingSilver = coachSignUp.WillingSilver,
                WillingGold = coachSignUp.WillingGold,
                WillingPlat = coachSignUp.WillingPlat,
                WillingDiamond = coachSignUp.WillingDiamond,

                AvailabilityInfo = new AvailabilitySignUpDM
                {
                    MondayStart = coachSignUp.AvailabilityInfo.MondayStart,
                    MondayEnd = coachSignUp.AvailabilityInfo.MondayEnd,
                    TuesdayStart = coachSignUp.AvailabilityInfo.TuesdayStart,
                    TuesdayEnd = coachSignUp.AvailabilityInfo.TuesdayEnd,
                    WednesdayStart = coachSignUp.AvailabilityInfo.WednesdayStart,
                    WednesdayEnd = coachSignUp.AvailabilityInfo.WednesdayEnd,
                    ThursdayStart = coachSignUp.AvailabilityInfo.ThursdayStart,
                    ThursdayEnd = coachSignUp.AvailabilityInfo.ThursdayEnd,
                    FridayStart = coachSignUp.AvailabilityInfo.FridayStart,
                    FridayEnd = coachSignUp.AvailabilityInfo.FridayEnd,
                    SaturdayStart = coachSignUp.AvailabilityInfo.SaturdayStart,
                    SaturdayEnd = coachSignUp.AvailabilityInfo.SaturdayEnd,
                    SundayStart = coachSignUp.AvailabilityInfo.SundayStart,
                    SundayEnd = coachSignUp.AvailabilityInfo.SundayEnd,
                },
                Languages = coachSignUp.Languages,
                PairedPlayers = coachSignUp.PairedPlayers,
                CoachingStyle = coachSignUp.CoachingStyle,
                CoachingExperience = coachSignUp.CoachingExperience,
                Commitment = new CommitmentSignUpDM
                {
                    CommitmentLevel = coachSignUp.Commitment.CommitmentLevel,
                    SeriousnessLevel = coachSignUp.Commitment.SeriousnessLevel
                },
                Toxic = new ToxicSignUpDM
                {
                    ToxicLevel = coachSignUp.Toxic.ToxicLevel,
                    HadLowPriorityPunish = coachSignUp.Toxic.HadLowPriorityPunish,
                    HadChatRestrictions = coachSignUp.Toxic.HadChatRestrictions,
                    HadRankedRestrictions = coachSignUp.Toxic.HadRankedRestrictions,
                    HadTemporaryBan = coachSignUp.Toxic.HadTemporaryBan,
                    HadPermanentBan = coachSignUp.Toxic.HadPermanentBan
                },
                MoreInformation = coachSignUp.MoreInformation,
                EmailSignUp = coachSignUp.EmailSignUp
            });
        }       
    }
}