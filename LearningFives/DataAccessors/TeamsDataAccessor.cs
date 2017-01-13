using DataModels.SignUp;
using DataModels.Teams;
using Entities;
using Interfaces.DataAccessors;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class TeamsDataAccessor : ITeamsDataAccessor
    {
        public async Task<List<StudentProfileDM>> GetAllStudentsAsync(StudentFilterDM studentFilter)
        {
            using (var context = new LearningFivesEntities())
            {
                var filter = context.StudentSignUps.AsQueryable();

                if (studentFilter.StudentStatus >= 0)
                {
                    filter = filter.Where(i => i.StudentStatus == studentFilter.StudentStatus);
                }

                if (!string.IsNullOrEmpty(studentFilter.Server))
                {
                    filter = filter.Where(i => i.SummonerInfo.ServerName == studentFilter.Server);
                }

                if (!string.IsNullOrEmpty(studentFilter.RankTier))
                {
                    var studentList = new List<StudentSignUp>();
                    foreach (var item in filter)
                    {
                        var league = item.SummonerInfo?.RiotAPISummoners?.FirstOrDefault()?.RiotAPILeagues?.FirstOrDefault();
                        if (league != null && league.Tier == studentFilter.RankTier)
                        {
                            studentList.Add(item);
                        }
                    }

                    filter = studentList.AsQueryable();
                }

                var fil = await filter.OrderBy(i => i.SummonerInfo.SummonerName).ToListAsync();

                var list = new List<StudentProfileDM>();
                foreach (var student in fil)
                {
                    var summonerInfo = student.SummonerInfo;
                    var riotApiInfo = summonerInfo.RiotAPISummoners.FirstOrDefault();

                    List<RiotApiLeagueDM> leagues = null;
                    if (riotApiInfo != null)
                    {
                        leagues = riotApiInfo.RiotAPILeagues?.Select(league => new RiotApiLeagueDM
                        {
                            LeagueName = league.LeagueName,
                            QueueType = league.QueueType,
                            Tier = league.Tier,
                            LeagueEntries = league.RiotAPILeagueEntries?.Select(leagueEntry => new RiotApiLeagueEntryDM
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
                        }).ToList();
                    }

                    list.Add(new StudentProfileDM
                    {
                        StudentStatus = student.StudentStatus,
                        SummonerInfo = new SummonerInfoDM
                        {
                            SummonerInfoId = summonerInfo.SummonerInfoID,
                            SummonerName = summonerInfo.SummonerName,
                            Server = summonerInfo.ServerName,
                            Age = summonerInfo.Age,
                            Email = summonerInfo.Email,
                            RiotApiInfo = riotApiInfo == null ? null : new RiotApiSummonerDM
                            {
                                RiotApiSummonerId = riotApiInfo.RiotAPISummonerID,
                                ProfileIconId = riotApiInfo.ProfileIconID,
                                RevisionDate = riotApiInfo.RevisionDate,
                                SummonerLevel = riotApiInfo.SummonerLevel,
                                Leagues = leagues
                            }
                        },

                        RoleInfo = new RoleSignUpDM
                        {
                            PreferredRole = student.RoleInfo.PreferredRole,
                            TopLane = student.RoleInfo.TopLane,
                            Jungle = student.RoleInfo.Jungle,
                            MidLane = student.RoleInfo.MidLane,
                            Adc = student.RoleInfo.Adc,
                            Support = student.RoleInfo.Support
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
                    });
                }
                return list;
            }
        }

        public async Task<List<CoachProfileDM>> GetAllCoachesAsync(CoachFilterDM coachFilter)
        {
            using (var context = new LearningFivesEntities())
            {
                var filter = context.CoachSignUps.AsQueryable();

                if (coachFilter.CoachStatus > 0)
                {
                    filter = filter.Where(i => i.CoachStatus == coachFilter.CoachStatus);
                }

                if (!string.IsNullOrEmpty(coachFilter.Server))
                {
                    filter = filter.Where(i => i.SummonerInfo.ServerName == coachFilter.Server);
                }

                if (!string.IsNullOrEmpty(coachFilter.RankTier))
                {
                    var coachList = new List<CoachSignUp>();
                    foreach (var item in filter)
                    {
                        var league = item.SummonerInfo?.RiotAPISummoners?.FirstOrDefault()?.RiotAPILeagues?.FirstOrDefault();
                        if (league != null && league.Tier == coachFilter.RankTier)
                        {
                            coachList.Add(item);
                        }
                    }

                    filter = coachList.AsQueryable();
                }

                var fil = await filter.OrderBy(i => i.SummonerInfo.SummonerName).ToListAsync();

                var list = new List<CoachProfileDM>();
                foreach (var coach in fil)
                {
                    var summonerInfo = coach.SummonerInfo;
                    var riotApiInfo = summonerInfo.RiotAPISummoners.FirstOrDefault();

                    List<RiotApiLeagueDM> leagues = null;
                    if (riotApiInfo != null)
                    {
                        leagues = riotApiInfo.RiotAPILeagues?.Select(league => new RiotApiLeagueDM
                        {
                            LeagueName = league.LeagueName,
                            QueueType = league.QueueType,
                            Tier = league.Tier,
                            LeagueEntries = league.RiotAPILeagueEntries?.Select(leagueEntry => new RiotApiLeagueEntryDM
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
                        }).ToList();
                    }

                    list.Add(new CoachProfileDM
                    {
                        CoachStatus = coach.CoachStatus,
                        SummonerInfo = new SummonerInfoDM
                        {
                            SummonerInfoId = summonerInfo.SummonerInfoID,
                            SummonerName = summonerInfo.SummonerName,
                            Server = summonerInfo.ServerName,
                            Age = summonerInfo.Age,
                            Email = summonerInfo.Email,
                            RiotApiInfo = riotApiInfo == null ? null : new RiotApiSummonerDM
                            {
                                RiotApiSummonerId = riotApiInfo.RiotAPISummonerID,
                                ProfileIconId = riotApiInfo.ProfileIconID,
                                RevisionDate = riotApiInfo.RevisionDate,
                                SummonerLevel = riotApiInfo.SummonerLevel,
                                Leagues = leagues
                            }
                        },
                        InterestedRank = coach.InterestedRank,
                        WillingBronze = coach.WillingBronze,
                        WillingSilver = coach.WillingSilver,
                        WillingGold = coach.WillingGold,
                        WillingPlat = coach.WillingPlat,
                        WillingDiamond = coach.WillingDiamond,
                        AvailabilityInfo = new AvailabilitySignUpDM
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
                        Commitment = new CommitmentSignUpDM
                        {
                            CommitmentLevel = coach.Commitment.CommitmentLevel,
                            SeriousnessLevel = coach.Commitment.SeriousnessLevel
                        },
                        Toxic = new ToxicSignUpDM
                        {
                            ToxicLevel = coach.Toxic.ToxicLevel,
                            HadLowPriorityPunish = coach.Toxic.HadLowPriorityPunish,
                            HadChatRestrictions = coach.Toxic.HadChatRestriction,
                            HadRankedRestrictions = coach.Toxic.HadRankedRestrictions,
                            HadTemporaryBan = coach.Toxic.HadTemporaryBan,
                            HadPermanentBan = coach.Toxic.HadPermanentBan
                        },
                        MoreInformation = coach.MoreInformation,
                        EmailSignUp = coach.EmailSignUp
                    });
                }
                return list;
            }
        }
    }
}