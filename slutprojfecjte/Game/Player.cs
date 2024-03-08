using System.Numerics;

using Raylib_cs;

public class PlayerClass : Entity
{
    //declaration (pallar inte med engelskan längre tbh får se ifall jag ändrar senare)
    private readonly GameMananger _gameMananger;
    private readonly int PlayerHeight = 15;
    private readonly int PlayerWidth = 15;
    private Rectangle _playerRectangle;

    private ApplyGravity _Gravity;

    //Constructor // set variablerna
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


    //Override för att ändra hur Draw() funktionen ska fungera för att göra det mer appealing till sig själv
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

        // * Ändra senare så det är en action för en inputsystem
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
        // * gör detta till sin egna ksk för lättare för movement för andra saker
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