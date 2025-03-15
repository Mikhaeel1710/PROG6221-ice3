using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Rectangle: Shape,iCalculatearea
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public override string name { get { return "Rectangle"; } }
        public double area;

        public Rectangle(double length, double breadth ,string name) :base(name)
        {
            this.length = length;
            this.breadth = breadth;
            name = name;
        
        
        
        }
        public override void Display() 
        {
            double roundedDouble;
            Console.WriteLine($"Name: {name} \nArea: { roundedDouble = Math.Round(area, 2)}");
        
        }
        public void ICalculateArea()
        {
            area = length * breadth;
        }

    }
}
