using DataModels.SignUp;
using Entities;
using Interfaces.DataAccessors;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class AdminDataAccessor : IAdminDataAccessor
    {
        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync()
        {
            using (var context = new LearningFivesEntities())
            {
                return await context.StudentSignUps.Select(student => new StudentSignUpDM
                {
                    StudentStatus = student.StudentStatus,
                    SummonerInfo = new SummonerSignUpDM
                    {
                        SummonerName = student.SummonerInfo.SummonerName,
                        Server = student.SummonerInfo.ServerName,
                        RankTier = student.SummonerInfo.RankTier,
                        RankDivision = student.SummonerInfo.RankDivision,
                        Age = student.SummonerInfo.Age,
                        Email = student.SummonerInfo.Email,
                        HasSlackAccount = student.SummonerInfo.HasSlackAccount
                    },
                    RoleInfo = new RoleSignUpDM
                    {
                        PreferredRole = student.RoleInfo.PreferredRole,
                        TopLaneComfort = student.RoleInfo.TopLaneComfort,
                        JungleComfort = student.RoleInfo.JungleComfort,
                        MidComfort = student.RoleInfo.MidComfort,
                        MarksmanComfort = student.RoleInfo.MarksmanComfort,
                        SupportComfort = student.RoleInfo.SupportComfort
                    },
                    AvailabilityInfo = new AvailabilitySignUpDM
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
                    Commitment = new CommitmentSignUpDM
                    {
                        CommitmentLevel = student.Commitment.CommitmentLevel,
                        SeriousnessLevel = student.Commitment.SeriousnessLevel
                    },
                    Toxic = new ToxicSignUpDM
                    {
                        ToxicLevel = student.Toxic.ToxicLevel,
                        HadLowPriorityPunish = student.Toxic.HadLowPriorityPunish,
                        HadChatRestrictions = student.Toxic.HadChatRestriction,
                        HadRankedRestrictions = student.Toxic.HadRankedRestrictions,
                        HadTemporaryBan = student.Toxic.HadTemporaryBan,
                        HadPermanentBan = student.Toxic.HadPermanentBan
                    },
                    MoreInformation = student.MoreInformation,
                    EmailSignUp = student.EmailSignUp
                }).ToListAsync();
            }
        }
    }
}