using Microsoft.AspNetCore.SignalR;

public class PuzzleHub : Hub<IGameControl>
{
    public PuzzleHub(Session game)
    {
        this.game = game;
    }
    Session game;

    public Task Join(string user)
    {
        if (game != null)
        {
            if (CheckPlayer(user) != true)
            {
                game.Players.Add(new Player() { Name = user });
            }
        }
        return Clients.All.SendSession(game);
    }
    public bool CheckPlayer(string user)
    {
        for (int r = 0; r < game.Players.Count; r++)
        {
            if (user == game.Players[r].Name)
            {
                return true;
            }
        }
        return false;
    }

    public Task GetDimension(int size)
    {
        game.Dimension = size;
        foreach (var player in game.Players)
        {
            player.Game = new Puzzle(size);
        }
        return Clients.All.GetReady(game);
    }

}
