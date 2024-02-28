using System.Numerics;
using Raylib_cs;

public class Wall : GameObject
{
    private Rectangle _rectangle;

    public Wall(Vector2 _position, int Width, int Height)
    {
        _rectangle = new Rectangle(_position, Width, Height);
    }


    public override void Draw()
    {
        Raylib.DrawRectangleRec(_rectangle, Color.Black);
    }
}