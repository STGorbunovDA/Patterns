using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

public class Hero
{
    private Weapon weapon;
    private Movement movement;
    public Hero(HeroFactory factory)
    {
        weapon = factory.CreateWeapon();
        movement = factory.CreateMovement();
    }
    public void Run()
    {
        movement.Move();
    }
    public void Hit()
    {
        weapon.Strike();
    }
}
