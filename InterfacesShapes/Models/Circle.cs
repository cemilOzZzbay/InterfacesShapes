using InterfacesShapes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models
{
    class Circle : IRoundedShape
    {
        public double Radius { get; set; }
        public bool IsPiThree { get; set; } = true;

        public double CalculateArea()
        {
            //double pi = Math.PI;
            //if (IsPiThree)
            //pi = 3;
            double pi = IsPiThree ? 3 : Math.PI; // (Ternary Operator)

            return pi * Math.Pow(Radius, 2);

        }

        public double CalculateCircumference()
        {
            //double pi = Math.PI;
            //if (IsPiThree)
            //pi = 3;
            double pi = IsPiThree ? 3 : Math.PI; // (Ternary Operator)

            return 2 * pi * Radius;
        }
    }
}
