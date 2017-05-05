using Interfaces.DataAccessors;
using System.Threading.Tasks;

namespace DataAccessors
{
    public class SignUpDataAccessor : ISignUpDataAccessor
    {
        public async Task<bool> RegisterStudent(StudentSignUp studentSignUp)
        {
            using (var context = new LearningFivesEntities())
            {
                context.StudentSignUps.Add(studentSignUp);
                return await context.SaveChangesAsync() > 0;
            }
        }

        public async Task<bool> RegisterCoach(CoachSignUp coachSignUp)
        {
            using (var context = new LearningFivesEntities())
            {
                context.CoachSignUps.Add(coachSignUp);
                return await context.SaveChangesAsync() > 0;
            }
        }
    }
}