using System;

// Base class Shape
public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public virtual double Area { get; }

    public Shape(double height, double width)
    {
        Height = height;
        Width = width;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    public Rectangle(double height, double width) : base(height, width) { }

    public override double Area => Height * Width;
}

// Derived class Square (inherits from Shape, ensures Height = Width)
public class Square : Shape
{
    public Square(double side) : base(side, side) { }

    public override double Area => Height * Height; // Same as Width * Width
}

// Derived class Circle (interpreting radius as average of Height and Width divided by 2)
public class Circle : Shape
{
    public Circle(double diameter) : base(diameter, diameter) { }

    public override double Area
    {
        get
        {
            double radius = (Height + Width) / 4; // Average of H and W, then halved for radius
            return Math.PI * radius * radius;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var r = new Rectangle(3, 4.5);
        WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");

        var s = new Square(5);
        WriteLine($"Square    H: {s.Height}, W: {s.Width}, Area: {s.Area}");

        var c = new Circle(5);
        WriteLine($"Circle    H: {c.Height}, W: {c.Width}, Area: {c.Area}");
    }

    // Helper method to shorten Console.WriteLine
    static void WriteLine(string message) => Console.WriteLine(message);
}