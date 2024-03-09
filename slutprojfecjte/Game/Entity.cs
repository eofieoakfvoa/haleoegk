using Raylib_cs;
public class Entity : GameObject
{
    public int Health { get; set; }
    public int MovementSpeed { get; set; }
    public bool CanTakeDamage { get; set; }

    public void TakeDamage(int Damage) // They shall take inpairment to own self, but Only if thee can taketh damage.
    {

        if (CanTakeDamage && Damage >= 0)
        {
            Health -= Damage;

            if (Health <= 0)
            {
                HandleDeath();
            }
        }
    }
    public virtual void HandleDeath() { } // They who inheritance  changeth the function to a more pleasurable useth case.
}