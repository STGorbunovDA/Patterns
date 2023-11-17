using FactoryMethod.Classes.Info.Base;

namespace FactoryMethod.Classes.Info;

class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod() { return new ConcreteProductA(); }
}
