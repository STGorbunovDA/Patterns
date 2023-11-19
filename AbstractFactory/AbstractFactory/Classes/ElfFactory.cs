using AbstractFactory.Classes.Base;

namespace AbstractFactory.Classes;

// Фабрика создания летящего героя с арбалетом
class ElfFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new FlyMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new Arbalet();
    }
}
