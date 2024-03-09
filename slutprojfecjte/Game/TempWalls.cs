using System.Numerics;
using Raylib_cs;

public class Wall : GameObject
{
    private Rectangle _rectangle;
    private RectangleHitbox _Hitbox;

    public Wall(Vector2 _position, int Width, int Height)
    {
        _rectangle = new Rectangle(_position, Width, Height);
        _Hitbox = new(_rectangle);
    }


    public override void Draw()
    {
        Raylib.DrawRectangleRec(_rectangle, Color.Black);
    }
}