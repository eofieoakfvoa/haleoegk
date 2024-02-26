using Raylib_cs;
public class Entity : GameObject
{
    private int _Health;
    private bool _canHurted;
    
    public int Health
    {
        get {return _Health;}
        set {_Health = value;}
    }

    public void TakeDamage(int Damage)
    {
        if (_canHurted)
        {
            _Health -= Damage;
            if (_Health <= 0)
            {
                HandleDeath();
            } 
        }
    }
    public virtual void HandleDeath(){}
}