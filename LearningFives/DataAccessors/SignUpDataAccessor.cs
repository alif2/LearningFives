using DataModels.SignUp;
using Entities;
using Interfaces.DataAccessors;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class SignUpDataAccessor : ISignUpDataAccessor
    {
        public async Task<bool> RegisterStudent(StudentSignUpDM studentSignUp)
        {
            using (var context = new LearningFivesEntities())
            {
                context.StudentSignUps.Add(new StudentSignUp
                {
                    StudentStatus = studentSignUp.StudentStatus,
                    SummonerInfo = new SummonerInfo
                    {
                        SummonerName = studentSignUp.SummonerInfo.SummonerName,
                        ServerName = studentSignUp.SummonerInfo.Server,
                        Age = studentSignUp.SummonerInfo.Age,
                        Email = studentSignUp.SummonerInfo.Email
                    },
                    RoleInfo = new RoleInfo
                    {
                        PreferredRole = studentSignUp.RoleInfo.PreferredRole,
                        TopLane = studentSignUp.RoleInfo.TopLane,
                        Jungle = studentSignUp.RoleInfo.Jungle,
                        MidLane = studentSignUp.RoleInfo.MidLane,
                        Adc = studentSignUp.RoleInfo.Adc,
                        Support = studentSignUp.RoleInfo.Support
                    },
                    AvailabilityInfo = new AvailabilityInfo
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
                    Commitment = new Commitment
                    {
                        CommitmentLevel = studentSignUp.Commitment.CommitmentLevel,
                        SeriousnessLevel = studentSignUp.Commitment.SeriousnessLevel
                    },
                    Toxic = new Toxic
                    {
                        ToxicLevel = studentSignUp.Toxic.ToxicLevel,
                        HadLowPriorityPunish = studentSignUp.Toxic.HadLowPriorityPunish,
                        HadChatRestriction = studentSignUp.Toxic.HadChatRestrictions,
                        HadRankedRestrictions = studentSignUp.Toxic.HadRankedRestrictions,
                        HadTemporaryBan = studentSignUp.Toxic.HadTemporaryBan,
                        HadPermanentBan = studentSignUp.Toxic.HadPermanentBan
                    },
                    MoreInformation = studentSignUp.MoreInformation,
                    EmailSignUp = studentSignUp.EmailSignUp
                });

                return await context.SaveChangesAsync() > 0;
            }
        }

        public async Task<bool> RegisterCoach(CoachSignUpDM coachSignUp)
        {
            using (var context = new LearningFivesEntities())
            {
                context.CoachSignUps.Add(new CoachSignUp
                {
                    CoachStatus = coachSignUp.CoachStatus,
                    SummonerInfo = new SummonerInfo
                    {
                        SummonerName = coachSignUp.SummonerInfo.SummonerName,
                        ServerName = coachSignUp.SummonerInfo.Server,
                        Age = coachSignUp.SummonerInfo.Age,
                        Email = coachSignUp.SummonerInfo.Email
                    },
                    InterestedRank = coachSignUp.InterestedRank.PreferredStudentRank,

                    WillingBronze = coachSignUp.WillingBronze,
                    WillingSilver = coachSignUp.WillingSilver,
                    WillingGold = coachSignUp.WillingGold,
                    WillingPlat = coachSignUp.WillingPlat,
                    WillingDiamond = coachSignUp.WillingDiamond,

                    AvailabilityInfo = new AvailabilityInfo
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
                        SundayEnd = coachSignUp.AvailabilityInfo.SundayEnd
                    },
                    Languages = coachSignUp.Languages,
                    PairedPlayers = coachSignUp.PairedPlayers,
                    CoachingStyle = coachSignUp.CoachingStyle,
                    CoachingExperience = coachSignUp.CoachingExperience,
                    Commitment = new Commitment
                    {
                        CommitmentLevel = coachSignUp.Commitment.CommitmentLevel,
                        SeriousnessLevel = coachSignUp.Commitment.SeriousnessLevel
                    },
                    Toxic = new Toxic
                    {
                        ToxicLevel = coachSignUp.Toxic.ToxicLevel,
                        HadLowPriorityPunish = coachSignUp.Toxic.HadLowPriorityPunish,
                        HadChatRestriction = coachSignUp.Toxic.HadChatRestrictions,
                        HadRankedRestrictions = coachSignUp.Toxic.HadRankedRestrictions,
                        HadTemporaryBan = coachSignUp.Toxic.HadTemporaryBan,
                        HadPermanentBan = coachSignUp.Toxic.HadPermanentBan
                    },
                    MoreInformation = coachSignUp.MoreInformation,
                    EmailSignUp = coachSignUp.EmailSignUp
                });

                return await context.SaveChangesAsync() > 0;
            }
        }
    }
}