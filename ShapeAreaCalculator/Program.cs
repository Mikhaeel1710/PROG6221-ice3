namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3, 4, "rectangle");
            rect.ICalculateArea();
            rect.Display();
            Console.WriteLine();
            Circle1 circ = new Circle1(5, "circle");
            circ.ICalculateArea();
            circ.Display();
        }
    }
}
