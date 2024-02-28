using Raylib_cs;
public class Entity : GameObject
{
    private int _Health;
    private bool _canTakeDamage;
    private int _MovementSpeed;
    
    public int Health
    {
        get {return _Health;}
        set {_Health = value;}
    }
    public int MovementSpeed
    {
        get {return _MovementSpeed;}
        set {_MovementSpeed = value;}
    }
    public bool CanTakeDamage
    {
        get {return _canTakeDamage;}
        set {_canTakeDamage = value;}
    }

    public void TakeDamage(int Damage)
    {   

        if (_canTakeDamage && Damage >= 0)
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