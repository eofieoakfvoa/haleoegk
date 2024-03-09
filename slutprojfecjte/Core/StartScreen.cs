using System.Numerics;
using Raylib_cs;
public class StartScreen(GameMananger gameMananger)
{
    List<UIButton> buttons =
    [
    new UIButton(new(10, 400, 140, 30), () => gameMananger.SetCurrentScene = GameMananger.Scenes.Game, "Press here to Start"),
    new UIButton(new(160, 400, 140, 30), () => Console.WriteLine("whoa!")),
    ];



    public void Menu(Vector2 mousePosition)
    {
        if (Raylib.IsMouseButtonPressed(0))
        {
            foreach (UIButton b in buttons)
            {
                if (b.MouseHovering(mousePosition))
                {
                    b.Click();
                }
            }
        }

    }
    public void Draw()
    {
        buttons.ForEach(t => t.Draw());
    }
}