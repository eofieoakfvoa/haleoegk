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
    private Rectangle _Rectangle;
    public ApplyGravity(Rectangle Rectangle, float gravityScale, float Mass)
    {
        _Rectangle = Rectangle;
        _GravityScale = gravityScale;
        _Mass = Mass;

    }

    public void Gravity()
    {
        Console.WriteLine(_Rectangle.Position);
        _Rectangle.Y -= _GravityVariable;
    }

}