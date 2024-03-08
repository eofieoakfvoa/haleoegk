using System.Numerics;


public class GameObject
{
  protected Vector2 _Position;
    public Vector2 Position
    {
        get {return _Position;}
        set {_Position = value;}
    }

  public virtual void Update(float deltaTime)
  {

  }

  public virtual void Draw()
  {

  }
}
