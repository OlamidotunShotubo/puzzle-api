public interface IGameControl
{
    Task Play(string user, Direction direction);
    Task Join(string user);
    Task GetReady(Session game);
    Task PickDimension(string user);
    Task Stop(string user);
    Task SendSession(Session game);
     Task GetDimension(int size);
}