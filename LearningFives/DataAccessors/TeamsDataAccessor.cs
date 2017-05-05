using DataModels.Teams;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class TeamsDataAccessor
    {
        public async Task<List<StudentSignUp>> GetAllStudentsAsync(StudentFilterDM studentFilter)
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

                var list = new List<StudentSignUp>();
                foreach (var student in fil)
                {
                    var summonerInfo = student.SummonerInfo;
                    var riotApiInfo = summonerInfo.RiotAPISummoners.FirstOrDefault();

                    List<RiotAPILeague> leagues = null;
                    if (riotApiInfo != null)
                    {
                        leagues = riotApiInfo.RiotAPILeagues?.ToList();
                    }
           //TODO: Get leagues
                    list.Add(student);
                }
                return list;
            }
        }

        public async Task<List<CoachSignUp>> GetAllCoachesAsync(CoachFilterDM coachFilter)
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

                var list = new List<CoachSignUp>();
                foreach (var coach in fil)
                {
                    var summonerInfo = coach.SummonerInfo;
                    var riotApiInfo = summonerInfo.RiotAPISummoners.FirstOrDefault();

                    List<RiotAPILeague> leagues = null;
                    if (riotApiInfo != null)
                    {
                        leagues = riotApiInfo.RiotAPILeagues?.ToList();
                    }
                    
                    list.Add(coach);
                }
                return list;
            }
        }
    }
}