using MyApp.Entities.Shared;

namespace MyApp.Entities.Plans;

public record PlanId(string Value) : Id<PlanId>(Value);

public class Plan : Entity<PlanId>
{

}
