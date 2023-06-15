using MyApp.Entities.Shared;

namespace MyApp.Entities.SessionsAims;

public record SessionAimId(string Value) : Id<SessionAimId>(Value);

public class SessionAim : Entity<SessionAimId>
{

}
