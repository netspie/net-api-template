using MyApp.Entities.Shared;

namespace MyApp.Entities.Sessions;

public record SessionId(string Value) : Id<SessionId>(Value);

public class Session : Entity<SessionId>
{

}
