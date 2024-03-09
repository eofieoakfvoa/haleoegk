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
public class ApplyGravity(float gravityScale, float Mass)
{
    private readonly int _GravityVariable = 1;
    protected float _GravityScale = gravityScale;
    protected float _Mass = Mass;

    public Vector2 Gravity(Vector2 Position)
    {
        Position.Y += _GravityVariable;
        return Position;
    }

}