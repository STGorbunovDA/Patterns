/* Инфо

    * Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта 
      и позволяет разделить его на различные этапы.

    * Когда использовать паттерн Строитель?

    * Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот 
      объект состоит и как эти части связаны между собой

    * Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания

    * Рассмотрим применение паттерна на примере выпечки хлеба. Как известно, даже обычный хлеб 
      включает множество компонентов. Мы можем использовать для представления хлеба
      и его компонентов следующие классы:
*/


using Builder.Classes.Base;
using Builder.Classes.Product;
using Builder.Classes;

namespace Builder;
class Program
{
    static void Main()
    {
        // содаем объект пекаря
        Baker baker = new Baker();
        // создаем билдер для ржаного хлеба
        BreadBuilder builder = new RyeBreadBuilder();
        // выпекаем
        Bread ryeBread = baker.Bake(builder);
        Console.WriteLine(ryeBread.ToString());
        // cоздаем билдер для пшеничного хлеба
        builder = new WheatBreadBuilder();
        Bread wheatBread = baker.Bake(builder);
        Console.WriteLine(wheatBread.ToString());

        Console.Read();
    }
}