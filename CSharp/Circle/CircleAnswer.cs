namespace TeachingCoding.Challenges;

// a public class that can be built from outside the file
public class Circle
{
    // Privately settable property
    public double Radius { get; private set; }

    // Constructor with dimension radius passed in
    // Constructors are called like this:
    // "var circle = new Circle(radiusValue)"
    public Circle(double radius)
    {
        // set local property so the value can be used in subsequent calculations
        Radius = radius;
    }

    // Method that returns perimeter calculation's answer
    public double Perimeter()
    {
        return Radius * 2 * Math.PI;
    }

    // Method that returns area calculation's answer
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}