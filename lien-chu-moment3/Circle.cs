using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lien_chu_moment3
{
    // Create a derived class (inherit from BaseClassOfShapes)  to define data type.
    internal class Circle : BaseClassOfShapes
    {
        // Create property for subclass.
        public double _radius;

        // Create a constructor with an parameter and set properties.
        public Circle(double radius)
        {
            _radius = radius;
            Area = _radius * _radius * Math.PI;
            Perimeter = _radius * 2 * Math.PI;
            Name = "circle";
        }
        // Override methods
        public override double getArea() { return Area; }
        public override double getPerimeter() { return Perimeter; }
        public override string getFigureNam() { return "This is a cool " + Name; }

    }
}
