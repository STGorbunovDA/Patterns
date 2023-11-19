namespace Prototype.Interfaces;

interface IFigure
{
    IFigure Clone();
    object DeepCopy();
    void GetInfo(bool flag);
}
