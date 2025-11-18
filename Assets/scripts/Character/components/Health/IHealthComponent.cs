public interface IHealthComponent
{
    float Health { get; set; }
    float MaxHealth { get; set; }
    void SetDamage(int damage);
}


