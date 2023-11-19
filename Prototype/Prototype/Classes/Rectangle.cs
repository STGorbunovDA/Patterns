using Prototype.Interfaces;
using System.Runtime.Serialization;
using System.Text.Json;

namespace Prototype.Classes;

[DataContract]
class Rectangle : IFigure
{
    [DataMember]
    public Point Point { get; set; }

    public bool Flag { get; set; } = true;

    public Rectangle() { }

    public Rectangle(int x, int y)
    {
        this.Point = new Point { X = x, Y = y };
    }

    public IFigure Clone()
    {
        return this.MemberwiseClone() as IFigure;
    }

    public object DeepCopy()
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(Rectangle));
        using (MemoryStream stream = new MemoryStream())
        {
            serializer.WriteObject(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            Flag = false;
            return serializer.ReadObject(stream);
        }
    }

    public void GetInfo(bool flag)
    {
        if (flag)
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", Point.X, Point.Y);
        else Console.WriteLine("Глубокая копия прямоугольника длиной {0} и шириной {1}", Point.X, Point.Y);
    }
}
