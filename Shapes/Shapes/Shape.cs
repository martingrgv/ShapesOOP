namespace Shapes;

public class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * (Radius * Radius);
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}
 public class Rectangle : Shape
 {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
 }

 public class Parallelogram : Shape
 {
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Base * Height;
    }
}

public class Rhombus : Shape
{
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        if (Diagonal1 != 0 && Diagonal2 != 0)
        {
            return 05 * Diagonal1 * Diagonal2;
        }

        return Base * Height;
    }
}

 public class Trapezoid : Shape
 {
    public double BaseA { get; set; }
    public double BaseB { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return (BaseA + BaseB) / 2 * Height;
    }
}