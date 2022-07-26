// abstract class that cannot be instantiated
public abstract class Bird
{
    // abstract property that must be implemented
    protected abstract string Name { get; }

    // Method with implementation that cannot be overridden
    public void Fly()
    {
        Console.WriteLine($"The {Name} soars");
    }

    // Method with default implementation that can be overridden
    public virtual void Tweet()
    {
        Console.WriteLine("Tweet!");
    }
}

// inheriting class
public class Goose : Bird
{
    // abstract implementation
    protected override string Name { get => "Goose"; }

    // override
    public override void Tweet()
    {
        Console.WriteLine("Honk!");
    }
}