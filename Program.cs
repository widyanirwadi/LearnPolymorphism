namespace LearnPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle(4, 5);
            shapes[1] = new Circle(3);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Area: " + shape.CalculateArea());
            }
        }
    }
}