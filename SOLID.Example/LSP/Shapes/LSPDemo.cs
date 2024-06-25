
using System.Data;

namespace SOLID.Example.LSP.Shapes
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public double GetArea()
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
    public class Square : Rectangle
    {
        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Height = value; }
        }
        public override double Height
        {
            get { return base.Height; }
            set { base.Width = base.Height = value; }
        }
    }

    public class Apply
    {
        public void RunApply()
        {
            var rect = new Rectangle { Width = 2, Height = 3 };
            rect.ChangeDimensions(rect, 4, 5);  // This works fine

            var square = new Square { Width = 2 };
            rect.ChangeDimensions(square, 4, 5);  // This behaves unexpectedly!
        }
    }

    /// <summary>
    // in the above code there is a class named Square that is a subclass of the Rectangle class
    // and tries to enforce the rule to ensure that its width and height are equal.
    // However, this approach violates the Liskov Substitution Principle (LSP) because if a method is intended to work with a Rectangle object,
    // it may not function correctly when a Square instance is used as input.
    /// </summary>

}
