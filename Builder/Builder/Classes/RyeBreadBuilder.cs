using Builder.Classes.Base;
using Builder.Classes.Product.Base;

namespace Builder.Classes;

// строитель для ржаного хлеба
class RyeBreadBuilder : BreadBuilder
{
    public override void SetFlour()
    {
        Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
    }

    public override void SetSalt()
    {
        Bread.Salt = new Salt();
    }

    public override void SetAdditives()
    {
        // не используется
    }
}
