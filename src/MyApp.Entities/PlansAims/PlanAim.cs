using MyApp.Entities.Shared;

namespace MyApp.Entities.Plans;

public record PlanAimId(string Value) : Id<PlanAimId>(Value);

public class PlanAim : Entity<PlanAimId>
{
    public PlanId PlanId { get; private set; }
    public DateTime? StartDateUtc { get; private set; }

    public PlanAim(PlanId planId)
    {
        PlanId = planId;
        StartDateUtc = DateTime.UtcNow;
    }
}
