namespace Composite.Classes;

class Directory : Component
{
    private List<Component> Components = new();

    public Directory(string name) : base(name) { }
    
    public override void Add(Component component)
    {
        Components.Add(component);
    }

    public override void Remove(Component component)
    {
        Components.Remove(component);
    }

    public override void Print()
    {
        Console.WriteLine("Узел " + name);
        Console.WriteLine("Подузлы:");
        for (int i = 0; i < Components.Count; i++)
            Components[i].Print();
        
    }
}
