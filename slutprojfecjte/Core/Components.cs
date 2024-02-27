using Raylib_cs;
public class RectangleHitbox(Rectangle rectangle)
{
    private Rectangle Hitbox { get; set; } = rectangle;

    public bool CheckCollision(Rectangle other)
    {
        return Raylib.CheckCollisionRecs(Hitbox, other);
    }
}
public class ApplyGravity()
{
    private readonly int _GravityVariable;
    protected float _GravityScale;
    protected float _Mass;

}