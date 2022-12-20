using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lien_chu_moment3
{
    // Derived class (inherit from BaseClassOfShapes)
    internal class Square : BaseClassOfShapes
    {
        // Create a constructor with an parameter and set properties..
        public Square(double side1) 
        { 
            _side = side1;
            Area = _side * _side;
            Perimeter = _side * 4;
            Name = "Square";


        }
        // Override methods
        public override double getArea() { return Area; }
        public override double getPerimeter() { return Perimeter; }
        public override string getFigureNam() { return "This is a cool " + Name; }
    }
}