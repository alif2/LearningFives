using DataAccessors.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class TeamsDataAccessor
    {
        public const int TeamSizeLimit = 5;

        public async Task<List<StudentSignUp>> GetAllStudentsAsync(StudentFilterDM studentFilter)
        {
            using (var context = new LearningFivesEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var filter = context.StudentSignUps
                           .AsNoTracking()
                           .AsQueryable()
                           .Include(i => i.Commitment)
                           .Include(i => i.RoleInfo)
                           .Include(i => i.SummonerInfo)
                           .Include(i => i.SummonerInfo.RiotAPISummoners.Select(j => j.RiotAPILeagues))
                           .Include(i => i.Toxic);

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
                    filter = filter.Where(i => i.SummonerInfo.RiotAPISummoners.Count > 0);

                    filter = filter.Where(i => i.SummonerInfo.RiotAPISummoners
                             .Any(j => j.RiotAPILeagues
                             .Any(k => k.QueueType.Equals("RANKED_SOLO_5x5") && k.Tier == studentFilter.RankTier)));
                }
                
                return await filter.OrderBy(i => i.SummonerInfo.SummonerName).ToListAsync();
            }
        }

        public async Task<List<CoachSignUp>> GetAllCoachesAsync(CoachFilterDM coachFilter)
        {
            using (var context = new LearningFivesEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var filter = context.CoachSignUps
                           .AsNoTracking()
                           .AsQueryable()
                           .Include(i => i.Commitment)
                           .Include(i => i.SummonerInfo)
                           .Include(i => i.SummonerInfo.RiotAPISummoners.Select(j => j.RiotAPILeagues))
                           .Include(i => i.Toxic);

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
                    filter = filter.Where(i => i.SummonerInfo.RiotAPISummoners.Count > 0);

                    filter = filter.Where(i => i.SummonerInfo.RiotAPISummoners
                           .Any(j => j.RiotAPILeagues
                           .Any(k => k.QueueType.Equals("RANKED_SOLO_5x5") && k.Tier == coachFilter.RankTier)));
                }

                return await filter.OrderBy(i => i.SummonerInfo.SummonerName).ToListAsync();
            }
        }

        public async Task<CoachPlayer> AddStudentToCoachAsync(int coachSignUpId, int studentSignUpId)
        {
            using (var context = new LearningFivesEntities())
            {
                var teamSize = await context.CoachPlayers.Where(i => i.CoachSignUpID == coachSignUpId).CountAsync();
                if (teamSize >= TeamSizeLimit) return null;

                var coachPlayer = context.CoachPlayers.Add(new CoachPlayer
                {
                    CoachSignUp = context.CoachSignUps.FirstOrDefault(i => i.CoachSignUpID == coachSignUpId),
                    StudentSignUp = context.StudentSignUps.FirstOrDefault(i => i.StudentSignUpID == studentSignUpId)
                });

                await context.SaveChangesAsync();
                return coachPlayer;
            }
        }

        public async Task<CoachPlayer> RemoveStudentFromCoachAsync(int coachSignUpId, int studentSignUpId)
        {
            using (var context = new LearningFivesEntities())
            {
                var coachPlayer = context.CoachPlayers.FirstOrDefault(i => i.CoachSignUpID == coachSignUpId && i.StudentSignUpID == studentSignUpId);
                if (coachPlayer == null) return null;

                var result = context.CoachPlayers.Remove(coachPlayer);
                await context.SaveChangesAsync();
                return result;
            }
        }
    }
}