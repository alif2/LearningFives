using ActionModels.Teams;
using DataModels.Teams;
using Interfaces.Engines;
using Interfaces.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Teams;

namespace Managers
{
    public class TeamsManager : ITeamsManager
    {
        private readonly ITeamsEngine _teamsEngine;

        public TeamsManager(ITeamsEngine teamsEngine)
        {
            _teamsEngine = teamsEngine;
        }

        public async Task<List<StudentProfileAM>> GetAllStudentsAsync(StudentFilterVM studentFilter)
        {
            return (await _teamsEngine.GetAllStudentsAsync(new StudentFilterDM
            {
                StudentStatus = studentFilter.StudentStatus,
                Server = studentFilter.Server,
                RankTier = studentFilter.RankTier     
            }))
                .Select(student => new StudentProfileAM
                {
                    StudentStatus = student.StudentStatus,
                    SummonerInfo = new SummonerInfoAM
                    {
                        SummonerInfoId = student.SummonerInfo.SummonerInfoId,
                        SummonerName = student.SummonerInfo.SummonerName,
                        Server = student.SummonerInfo.Server,
                        Age = student.SummonerInfo.Age,
                        Email = student.SummonerInfo.Email,
                        RiotApiInfo = student.SummonerInfo.RiotApiInfo == null ? null : new RiotApiSummonerAM
                        {
                            RiotApiSummonerId = student.SummonerInfo.RiotApiInfo.RiotApiSummonerId,
                            ProfileIconId = student.SummonerInfo.RiotApiInfo.ProfileIconId,
                            RevisionDate = student.SummonerInfo.RiotApiInfo.RevisionDate,
                            SummonerLevel = student.SummonerInfo.RiotApiInfo.SummonerLevel,
                            Leagues = student.SummonerInfo.RiotApiInfo.Leagues?.Select(league => new RiotApiLeagueAM
                            {
                                LeagueName = league.LeagueName,
                                QueueType = league.QueueType,
                                Tier = league.Tier,
                                LeagueEntries = league.LeagueEntries?.Select(leagueEntry => new RiotApiLeagueEntryAM
                                {
                                    Division = leagueEntry.Division,
                                    IsFreshBlood = leagueEntry.IsFreshBlood,
                                    IsHotStreak = leagueEntry.IsHotStreak,
                                    IsInactive = leagueEntry.IsInactive,
                                    IsVeteran = leagueEntry.IsVeteran,
                                    LeaguePoints = leagueEntry.LeaguePoints,
                                    Losses = leagueEntry.Losses,
                                    Wins = leagueEntry.Wins
                                })
                            })
                        }
                    },
                    RoleInfo = new RoleSignUpAM
                    {
                        PreferredRole = student.RoleInfo.PreferredRole,
                        TopLane = student.RoleInfo.TopLane,
                        Jungle = student.RoleInfo.Jungle,
                        MidLane = student.RoleInfo.MidLane,
                        Adc = student.RoleInfo.Adc,
                        Support = student.RoleInfo.Support
                    },
                    AvailabilityInfo = new AvailabilitySignUpAM
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
                    Commitment = new CommitmentSignUpAM
                    {
                        CommitmentLevel = student.Commitment.CommitmentLevel,
                        SeriousnessLevel = student.Commitment.SeriousnessLevel
                    },
                    Toxic = new ToxicSignUpAM
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

        public async Task<List<CoachProfileAM>> GetAllCoachesAsync(CoachFilterVM coachFilter)
        {
            return (await _teamsEngine.GetAllCoachesAsync(new CoachFilterDM
            {
                CoachStatus = coachFilter.CoachStatus,
                Server = coachFilter.Server,
                RankTier = coachFilter.RankTier
            }))
                .Select(coach => new CoachProfileAM
                {
                    CoachStatus = coach.CoachStatus,
                    SummonerInfo = new SummonerInfoAM
                    {
                        SummonerInfoId = coach.SummonerInfo.SummonerInfoId,
                        SummonerName = coach.SummonerInfo.SummonerName,
                        Server = coach.SummonerInfo.Server,
                        Age = coach.SummonerInfo.Age,
                        Email = coach.SummonerInfo.Email,
                        RiotApiInfo = coach.SummonerInfo.RiotApiInfo == null ? null : new RiotApiSummonerAM
                        {
                            RiotApiSummonerId = coach.SummonerInfo.RiotApiInfo.RiotApiSummonerId,
                            ProfileIconId = coach.SummonerInfo.RiotApiInfo.ProfileIconId,
                            RevisionDate = coach.SummonerInfo.RiotApiInfo.RevisionDate,
                            SummonerLevel = coach.SummonerInfo.RiotApiInfo.SummonerLevel,
                            Leagues = coach.SummonerInfo.RiotApiInfo.Leagues?.Select(league => new RiotApiLeagueAM
                            {
                                LeagueName = league.LeagueName,
                                QueueType = league.QueueType,
                                Tier = league.Tier,
                                LeagueEntries = league.LeagueEntries?.Select(leagueEntry => new RiotApiLeagueEntryAM
                                {
                                    Division = leagueEntry.Division,
                                    IsFreshBlood = leagueEntry.IsFreshBlood,
                                    IsHotStreak = leagueEntry.IsHotStreak,
                                    IsInactive = leagueEntry.IsInactive,
                                    IsVeteran = leagueEntry.IsVeteran,
                                    LeaguePoints = leagueEntry.LeaguePoints,
                                    Losses = leagueEntry.Losses,
                                    Wins = leagueEntry.Wins
                                })
                            })
                        }
                    },
                    InterestedRank = coach.InterestedRank,
                    WillingBronze = coach.WillingBronze,
                    WillingSilver = coach.WillingSilver,
                    WillingGold = coach.WillingGold,
                    WillingPlat = coach.WillingPlat,
                    WillingDiamond = coach.WillingDiamond,
                    AvailabilityInfo = new AvailabilitySignUpAM
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
                    Commitment = new CommitmentSignUpAM
                    {
                        CommitmentLevel = coach.Commitment.CommitmentLevel,
                        SeriousnessLevel = coach.Commitment.SeriousnessLevel
                    },
                    Toxic = new ToxicSignUpAM
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