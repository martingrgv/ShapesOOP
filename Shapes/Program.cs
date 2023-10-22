namespace Shapes;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();       

        Circle cir = new Circle(){ Radius = 5 };
        Triangle tri = new Triangle(){ Base = 5, Height = 3 };
        Square sqr = new Square(){ Side = 5 };
        Rectangle rec = new Rectangle(){ Width = 5, Height = 3 };
        Parallelogram par = new Parallelogram(){ Base = 5, Height = 3};
        Rhombus rh = new Rhombus(){ Diagonal1 = 5, Diagonal2 = 3 };
        Trapezoid trap = new Trapezoid(){ BaseA = 5, BaseB = 3, Height = 2 };

        shapes.Add(cir);
        shapes.Add(tri);
        shapes.Add(sqr);
        shapes.Add(rec);
        shapes.Add(par);
        shapes.Add(rh);
        shapes.Add(trap);

        foreach (var shape in shapes)
        {
            System.Console.WriteLine(Math.Round(shape.CalculateArea(), 2));
        }
    }
}
