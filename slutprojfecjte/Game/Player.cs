using System.Numerics;
using System.Security.Cryptography;
using Raylib_cs;

public class PlayerClass : Entity
{
    private GameMananger _gameMananger;
    
    public PlayerClass(GameMananger gameManager)
    {
        
        _gameMananger = gameManager;
        CanTakeDamage = true;
        Health = 5;
        _position = new Vector2(60,60);
        playerRectangle = new Rectangle(_position,15,15);
    }
    //private RectangleHitbox hitbox = new(new Rectangle(0,0,15,15));
    private Rectangle playerRectangle;
    public override void Draw()
    {
        Raylib.DrawRectangleRec(playerRectangle, Color.Black);
    }
    public override void HandleDeath()
    {
        _gameMananger.SetCurrentScene = GameMananger.Scenes.StartMenu;
    }
    public override void Update(float deltaTime)
    {
        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            Console.WriteLine(_position);
            Movement("Vertical", -4);
        }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            Movement("Vertical", 4);
        }
        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            Movement("Horizontal", -4);
        }
        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            Movement("Horizontal", 4);
            Console.WriteLine(Health);
            TakeDamage(1);
        }
    }
    private void Movement(string Direction, int Speed)
    {
        if (Direction == "Horizontal")
        {
            playerRectangle.X += Speed;
        }
        if (Direction == "Vertical")
        {
            playerRectangle.Y += Speed;
        }
    }
}