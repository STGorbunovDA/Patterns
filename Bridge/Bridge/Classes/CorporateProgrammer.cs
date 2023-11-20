using Bridge.Classes.Base;
using Bridge.Interfaces;

namespace Bridge.Classes;

class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage lang) : base(lang) { }
    public override void EarnMoney()
    {
        Console.WriteLine("Получаем в конце месяца зарплату");
    }
}
