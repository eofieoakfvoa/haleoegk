using Raylib_cs;
public class Entity : GameObject
{
    private int _Health;
    private bool _canTakeDamage;
    private int _movementSpeed;
    
    public int Health
    {
        get {return _Health;}
        set {_Health = value;}
    }
    public int MovementSpeed
    {
        get {return _movementSpeed;}
        set {_movementSpeed = value;}
    }
    public bool CanTakeDamage
    {
        get {return _canTakeDamage;}
        set {_canTakeDamage = value;}
    }

    public void TakeDamage(int Damage) // They shall take inpairment to own self, but only if thee can taketh damage.
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
    public virtual void HandleDeath(){} // They who inheritance  changeth the function to a more appaling useth case 
}