using System.Numerics;
using Raylib_cs;

public class Game
{
    private GameMananger _gameManager;
    private PlayerClass Player;
    public Game(GameMananger gameMananger)
    {
        _gameManager = gameMananger;
        Player = new(_gameManager);
    }
    public void game(Vector2 mousePosition, float deltaTime)
    {
        Player.Update(deltaTime);
    }

    public void Draw()
    {
        Player.Draw();
    }
}