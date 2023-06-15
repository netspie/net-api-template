using MyApp.Entities.Shared;

namespace MyApp.Entities.Exercises;

public record ExerciseId(string Value) : Id<ExerciseId>(Value);

public class Exercise : Entity<ExerciseId>
{

}
