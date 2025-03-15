using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Circle1 : Shape, iCalculatearea
    {
        public double radius { get; set; }
        public double area;
        public override string name { get { return "Circle"; } }
        public Circle1(double radius,string name) : base(name)
        {
            this.radius = radius;
            name = name;
        }
        public override void Display()
        {
            double roundedDouble;
            Console.WriteLine($"Name: {name} \nArea: {roundedDouble = Math.Round(area, 2)}");
        }
        public void ICalculateArea() {
            area = double.Pi * radius * radius;

        }
    }
}
