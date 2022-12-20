using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lien_chu_moment3
{
    // Derived class (inherit from BaseClassOfShapes)
    internal class Triangle : BaseClassOfShapes
    {

        // Create properties for subclass.
        private double _side2;
        private double _side3;

        // Create a constructor with 3 parameters and set properties.
        public Triangle(double side1, double side2, double side3)
        {
            _side = side1;
            _side2 = side2;
            _side3 = side3;
            double P = (base._side + _side2 + _side3) / 2;
            Area = Math.Sqrt(P * (P - base._side) * (P - _side2) * (P - _side3));
            Perimeter = base._side + _side2 + _side3;
            Name = "Triangle";
        }  

        // Override methods
        public override double getArea() { return Area; }
        public override double getPerimeter() { return Perimeter; }
        public override string getFigureNam() { return "This is a cool " + Name; }
      

    }
}