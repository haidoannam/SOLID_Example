
namespace SOLID.Example.LSP.Shapes.WithLSP
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
        public void ChangeDimensions(Rectangle rect, double width, double height)
        {
            rect.Width = width;
            rect.Height = height;
            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side;
        }
    }

    public class Apply
    {
        public void RunApply()
        {
            var rect = new Rectangle { Width = 2, Height = 3 };
            rect.GetArea();  // This works fine
            rect.ChangeDimensions(rect, 4, 5);  // This works fine
            var square = new Square { Side = 2 };
            square.GetArea();  // This also works fine

            // This will not work
            //square.ChangeDimensions(square, 4, 5); 
        }
    }
}
