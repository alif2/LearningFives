﻿using DataModels.SignUp;
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
        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync(int pageNumber, int pageSize)
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
                })
                .OrderBy(i => i.StudentStatus)
                .Skip((pageNumber - 1)*pageSize)
                .Take(pageSize)
                .ToListAsync();
            }
        }

        public async Task<List<CoachSignUpDM>> GetAllCoachesAsync(int pageNumber, int pageSize)
        {
            using (var context = new LearningFivesEntities())
            {
                return await context.CoachSignUps.Select(coach => new CoachSignUpDM
                {
                    CoachStatus = coach.CoachStatus,
                    SummonerInfo = new SummonerSignUpDM
                    {
                        SummonerName = coach.SummonerInfo.SummonerName,
                        Server = coach.SummonerInfo.ServerName,
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
                })
                .OrderBy(i => i.CoachStatus)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            }
        }

        public async Task<List<StudentSignUpDM>> FilterStudentsAsync(int studentStatusId = -1, string server = null, string rankTier = null)
        {
            var students = await GetAllStudentsAsync(1, 50);

            if (studentStatusId > 0)
            {
                students = students.Where(student => student.StudentStatus == studentStatusId).ToList();
            }

            if (server != null)
            {
                students = students.Where(student => student.SummonerInfo.Server == server).ToList();
            }

            if (rankTier != null)
            {
                students = students.Where(student => student.SummonerInfo.RankTier == rankTier).ToList();
            }

            return students;
        }

        public async Task<List<CoachSignUpDM>> FilterCoachesAsync(int coachStatusId = -1, string server = null, string rankTier = null)
        {
            var coaches = await GetAllCoachesAsync(1, 50);

            if (coachStatusId > 0)
            {
                coaches = coaches.Where(coach => coach.CoachStatus == coachStatusId).ToList();
            }

            if (server != null)
            {
                coaches = coaches.Where(coach => coach.SummonerInfo.Server == server).ToList();
            }

            if (rankTier != null)
            {
                coaches = coaches.Where(coach => coach.SummonerInfo.RankTier == rankTier).ToList();
            }

            return coaches;
        }
    }
}