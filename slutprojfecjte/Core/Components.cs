using Raylib_cs;
public class RectangleHitbox(Rectangle rectangle)
{
    private Rectangle Hitbox { get; set; } = rectangle;

    public bool CheckCollision(Rectangle other)
    {
        return Raylib.CheckCollisionRecs(Hitbox, other);
    }
}
public class ApplyGravity(Rectangle rectangle)
{
    private readonly int _GravityVariable = 1;
    protected float _GravityScale;
    protected float _Mass;

    public void Gravity()
    {
        rectangle.Y =- _GravityVariable * _GravityScale * _Mass;
    }

}