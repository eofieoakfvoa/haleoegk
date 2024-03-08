using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using Raylib_cs;

public class PlayerClass : Entity
{
    private readonly GameMananger _gameMananger;
    private readonly int PlayerHeight = 15;
    private readonly int PlayerWidth = 15;
    private Rectangle _playerRectangle;

    private ApplyGravity _Gravity;
    public PlayerClass(GameMananger gameManager)
    {
        
        _gameMananger = gameManager;
        CanTakeDamage = true;
        MovementSpeed = 4;
        Health = 5;
        Position = new Vector2(60,60);
        _playerRectangle = new Rectangle(Position,PlayerWidth,PlayerHeight);
        _Gravity = new(Position, 1,1);
    }



    public override void Draw()
    {
        Raylib.DrawRectangleRec(_playerRectangle, Color.Black);
    }
    public override void HandleDeath()
    {
        _gameMananger.SetCurrentScene = GameMananger.Scenes.StartMenu;
    }
    public override void Update(float deltaTime)
    {

        Console.WriteLine(_Position);
        Position = _Gravity.Gravity(Position); 

        _playerRectangle.Position = Position;


        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            Movement("Vertical", -MovementSpeed);
        }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            Movement("Vertical", MovementSpeed);
        }
        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            Movement("Horizontal", -MovementSpeed);
        }
        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            Movement("Horizontal", MovementSpeed);
        }
    }
    private void Movement(string Direction, int Speed)
    {
        if (Direction == "Horizontal")
        {
            _Position.X += Speed;
        }
        if (Direction == "Vertical")
        {
            _Position.Y += Speed;
        }
    }

}