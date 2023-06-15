using MyApp.Entities.Exercises;
using MyApp.Entities.Plans;
using MyApp.Entities.Sessions;
using MyApp.Entities.Shared;

namespace MyApp.Entities.Users;

public record UserId(string Value) : Id<UserId>(Value);

public class User : Entity<UserId>
{
    // Own created plans
    public List<PlanId> Plans { get; private set; }

    // Own created sessions
    public List<SessionId> Sessions { get; private set; }

    // Own created exercises
    public List<ExerciseId> Exercises { get; private set; }
}
