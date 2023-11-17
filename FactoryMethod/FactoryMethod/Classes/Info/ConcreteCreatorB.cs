using FactoryMethod.Classes.Info.Base;

namespace FactoryMethod.Classes.Info;

class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod() { return new ConcreteProductB(); }
}
