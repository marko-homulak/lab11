using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public abstract class Shape
    {
        protected virtual string name => "Shape";

        public string Name { get { return name; } }

        protected abstract double CalculateArea();

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
