namespace MyApp.Entities.Shared
{
    public interface IEntity<TId>
    {
        TId Id { get; }
        uint Version { get; set; }
    }
}
