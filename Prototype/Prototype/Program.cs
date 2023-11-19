/* Инфо

    * Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов. 
      То есть по сути данный паттерн предлагает технику клонирования объектов.

    * Когда использовать Прототип?

    * Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения

    * Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов-продуктов 
      из параллельной иерархии классов (как это делается, например, при использовании паттерна Абстрактная фабрика)

    * Когда клонирование объекта является более предпочтительным вариантом нежели его 
      создание и инициализация с помощью конструктора. Особенно когда известно, что объект 
      может принимать небольшое ограниченное число возможных состояний.
*/

/* Реализация
    
    * Участники
      
        * Prototype: определяет интерфейс для клонирования самого себя, который, как правило, 
          представляет метод Clone()

        * ConcretePrototype1 и ConcretePrototype2: конкретные реализации прототипа. Реализуют метод Clone()

        * Client: создает объекты прототипов с помощью метода Clone()
        
    * Здесь в качестве прототипа используется интерфейс IFigure, который реализуется классами Circle и Rectangle.

    * Но в данном случае надо заметить, что фреймворк .NET предлагает функционал для копирования 
      в виде метода MemberwiseClone(). Например, мы могли бы изменить реализацию метода Clone() 
      в классах прямоугольника и круга следующим образом:

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        
    * Причем данный метод был бы общим для обоих классов. И работа программы никак бы не изменилась.

    * В то же время надо учитывать, что метод MemberwiseClone() осуществляет неполное копирование - 
      то есть копирование значимых типов. Если же класс фигуры содержал бы объекты ссылочных типов, 
      то оба объекта после клонирования содержали бы ссылку на один и тот же ссылочный объект.
      Например, пусть фигура круг имеет свойство ссылочного типа:

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Circle : IFigure
        {
            int radius;
            public Point Point { get; set; }
            public Circle(int r, int x, int y)
            {
                radius = r;
                this.Point = new Point { X = x, Y = y };
            }
 
            public IFigure Clone()
            {
                return this.MemberwiseClone() as IFigure;
            }
            public void GetInfo()
            {
                Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
            }
        }

     * В этом случае при изменении значений в свойстве Point начальной фигуры автоматически 
       бы изменилось соответствующее значение и у клонированной фигуры:

        Circle figure = new Circle(30, 50, 60);
        Circle clonedFigure=figure.Clone() as Circle;
        figure.Point.X = 100; // изменяем координаты начальной фигуры
        figure.GetInfo(); // figure.Point.X = 100
        clonedFigure.GetInfo(); // clonedFigure.Point.X = 100

    Чтобы избежать подобной ситуации, надо применить полное копирование:

*/

using Prototype.Classes;
using Prototype.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IFigure сircle = new Circle(2, 30, 40);
        IFigure clonedFigure = (IFigure)сircle.DeepCopy();
        сircle.GetInfo(true);
        clonedFigure.GetInfo(false);

        IFigure rectangle = new Rectangle(30,40);
        clonedFigure = (IFigure)rectangle.DeepCopy();
        rectangle.GetInfo(true);
        clonedFigure.GetInfo(false);

        Console.Read();
    }
}