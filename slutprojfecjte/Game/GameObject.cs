using System.Numerics;


public class GameObject
{
  protected Vector2 _Position;
  public Vector2 Position
  {
    get { return _Position; }
    set { _Position = value; }
  }

  public virtual void Update(float deltaTime) //Thou who recievth shall maketh their own meaning of life
  {

  }

  public virtual void Draw() //Thou who recievth shall decideth their behold on life
  {

  }
}
