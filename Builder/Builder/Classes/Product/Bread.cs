using Builder.Classes.Product.Base;
using System.Text;

namespace Builder.Classes.Product;

// хлеб
class Bread
{
    // мука
    public Flour Flour { get; set; }
    // соль
    public Salt Salt { get; set; }

    // пищевые добавки
    public Additives Additives { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        if (Flour != null)
            sb.Append(Flour.Sort + "\n");
        if (Salt != null)
            sb.Append("Соль \n");
        if (Additives != null)
            sb.Append("Добавки: " + Additives.Name + " \n");
        return sb.ToString();
    }
}