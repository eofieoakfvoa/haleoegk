using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "GJAIGAV");
Raylib.SetTargetFPS(60);
List<UIButton> buttons = new();
buttons.Add(new UIButton(new(10, 400, 140, 30), () => Console.WriteLine("hey!"), "KLIKME"));
buttons.Add(new UIButton(new(160, 400, 140, 30), () => Console.WriteLine("whoa!")));
while (!Raylib.WindowShouldClose())
{
  float deltaTime = Raylib.GetFrameTime();
  Vector2 mousePosition = Raylib.GetMousePosition();

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
  

  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.White);

  buttons.ForEach(t => t.Draw());


  Raylib.EndDrawing();
}