using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Shape
    {
        public virtual string Name => "Shape"; // назва класу за замовчуванням

        public virtual double CalculateArea()
        {
            return 0.0; // за замовчуванням площа рівна нулю
        }

        public virtual string GetProperty()
        {
            return "";
        }
    }
}
