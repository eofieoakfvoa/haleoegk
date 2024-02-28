using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "GJAIGAV");
Raylib.SetTargetFPS(60);


GameMananger gameMananger = new();
StartScreen startScreen = new(gameMananger);
Game game = new(gameMananger);


List<UIButton> buttons =
[
    new UIButton(new(10, 400, 140, 30), () => gameMananger.SetCurrentScene = GameMananger.Scenes.Game),
    new UIButton(new(160, 400, 140, 30), () => Console.WriteLine("whoa!")),
];

while (!Raylib.WindowShouldClose())
{
  
  GameMananger.Scenes CurrentScene = gameMananger.GetCurrentScene();
  float deltaTime = Raylib.GetFrameTime();
  Vector2 mousePosition = Raylib.GetMousePosition();
  


  if (CurrentScene == GameMananger.Scenes.Game)
  {
    game.game(mousePosition, deltaTime);
  }
  
  else if (CurrentScene == GameMananger.Scenes.StartMenu)
  {
    startScreen.Menu(mousePosition);

  }
  

  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.White);

  if (CurrentScene == GameMananger.Scenes.Game)
  {
    game.Draw();

  }
  
  else if (CurrentScene == GameMananger.Scenes.StartMenu)
  {
    startScreen.Draw();
  }


  Raylib.EndDrawing();

}