using MyApp.Entities.Shared;

namespace MyApp.Entities.ExercisesAims;

public record ExerciseAimId(string Value) : Id<ExerciseAimId>(Value);

public class ExerciseAim : Entity<ExerciseAimId>
{

}
