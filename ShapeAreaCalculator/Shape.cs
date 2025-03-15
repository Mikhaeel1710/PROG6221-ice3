using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    abstract class Shape
    {
        public abstract string name { get; }
        public Shape(string name)
        {
            
        }
        public  virtual void Display() { }

        

    }
}
