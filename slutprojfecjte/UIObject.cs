using System.Numerics;
using Raylib_cs;

public class UIObject : GameObject
{
    private bool _enabled = true;
    private string _name;
    private Vector3 _position;
    private int _zIndex;
    protected Rectangle _rect;
    protected string _text;

}
public class UIButton : UIObject
{
    private Action _action;
    public UIButton(Rectangle rectangle, Action action, string text = "")
    {
        _rect = rectangle;
        _text = text;
        _action = action;
    }
    public bool MouseHovering(Vector2 mousePosition)
    {
        return Raylib.CheckCollisionPointRec(mousePosition, _rect);
    }

    public void Click()
    {
        _action();
    }

    public override void Draw()
    {
        Raylib.DrawRectangleRec(_rect, Color.Green);
        Raylib.DrawText(_text, (int)_rect.X + 5, (int)_rect.Y + 5, 20, Color.Black);
    }
}
public class UITextField : UIObject
{
    public UITextField()
    {
        
    }
}