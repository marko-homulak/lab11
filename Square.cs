using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Square : Quadrilateral
    {
        protected override string name => "Square";

        public Square() { }

        public Square(double side1) 
        { 
            this.side1 = side1;
        }

        protected override double CalculateArea()
        {
            return side1 * side1;
        }

        public override string ToString()
        {
            return $"{name} (side: {side1}; area: {CalculateArea()})";
        }
    }
}
