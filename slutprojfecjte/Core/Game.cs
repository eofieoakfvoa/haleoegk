using System.Numerics;
using Raylib_cs;

public class Game
{
    List<Wall> rectangle =
    [
    new Wall(new Vector2(0,500), 200, 30),
    new Wall(new Vector2(600,500), 40, 60)
    ];

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
        rectangle.ForEach(t => t.Draw());
    }
}