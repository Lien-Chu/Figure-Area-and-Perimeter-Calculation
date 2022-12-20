using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lien_chu_moment3
{
    // Derived class (inherit from BaseClassOfShapes)
    internal class Rectangle : BaseClassOfShapes
    {
        // Create property for subclass.
        private double _side2;

        // Create a constructor with 2 parameters and set properties.
        public Rectangle(double side1, double side2)
        {
            base._side = side1;
            _side2 = side2;
            Area = _side * _side2;
            Perimeter = _side * 2 + _side2 * 2;
            Name = "Rectangle";
        }
        // Override methods

        public override double getArea() { return Area; }
        public override double getPerimeter() { return Perimeter; }
        public override string getFigureNam() { return "This is a cool " + Name; }

    }
}
