using Builder.Classes.Product;

namespace Builder.Classes.Base;

// абстрактный класс строителя
abstract class BreadBuilder
{
    public Bread Bread { get; private set; }
    public void CreateBread()
    {
        Bread = new Bread();
    }
    public abstract void SetFlour();
    public abstract void SetSalt();
    public abstract void SetAdditives();
}
