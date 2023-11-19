using Prototype.Interfaces;
using System.Runtime.Serialization;

namespace Prototype.Classes;

[DataContract]
class Circle : IFigure
{
    [DataMember]
    private int Radius { get; set; }

    [DataMember]
    private Point Point { get; set; }

    public Circle()
    {

    }
    public Circle(int r, int x, int y)
    {
        Radius = r;
        this.Point = new Point { X = x, Y = y };
    }

    public IFigure Clone()
    {
        return this.MemberwiseClone() as IFigure; 
    }
    public object DeepCopy()
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(Circle));
        using (MemoryStream stream = new MemoryStream())
        {
            serializer.WriteObject(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            return serializer.ReadObject(stream);
        }
    }
    public void GetInfo(bool flag)
    {
        if (flag)
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", Radius, Point.X, Point.Y);
        else Console.WriteLine("Глубокая копия круга радиусом {0} и центром в точке ({1}, {2})", Radius, Point.X, Point.Y);
    }
}
