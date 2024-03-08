using System.Numerics;
using Raylib_cs;
public class RectangleHitbox(Rectangle rectangle)
{
    private Rectangle Hitbox { get; set; } = rectangle;

    public bool CheckCollision(Rectangle other)
    {
        return Raylib.CheckCollisionRecs(Hitbox, other);
    }
}
public class ApplyGravity
{
    private readonly int _GravityVariable = 1;
    protected float _GravityScale;
    protected float _Mass;
    private Vector2 _Position;
    public ApplyGravity(Vector2 Position, float gravityScale, float Mass)
    {
        
        _Position = Position;
        _GravityScale = gravityScale;
        _Mass = Mass;

    }

    public Vector2 Gravity(Vector2 Position)
    {
        Position.Y += _GravityVariable;
        return Position;
    }

}