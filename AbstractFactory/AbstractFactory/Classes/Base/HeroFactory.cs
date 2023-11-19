namespace AbstractFactory.Classes.Base;

// класс абстрактной фабрики
public abstract class HeroFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}
