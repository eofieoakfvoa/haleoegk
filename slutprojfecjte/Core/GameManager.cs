
public class GameMananger()
{
    public enum Scenes
    {
        Game,
        StartMenu,

    }
    private Scenes? _currentScene = Scenes.StartMenu;
    public Scenes SetCurrentScene
    {
        get {return (Scenes)_currentScene;}
        set
        {
            _currentScene = value;
            _currentScene ??= Scenes.StartMenu;
        }
    }
    public Scenes GetCurrentScene()
    {
        return (Scenes)_currentScene;
    }


}
