public interface IGameControl
{
    Task Play(Session gamer);
    Task SendPlay(Player gamer, ConsoleColor color);
    Task Join(string user);
    Task GetReady(Session game);
    Task PickDimension(string user);
    Task Stop(string user);
    Task SendSession(Session game);
    Task GetDimension(int size);
    Task GameOver(Session gamer);
}