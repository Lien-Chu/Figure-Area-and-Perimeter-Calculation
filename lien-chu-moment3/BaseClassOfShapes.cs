using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lien_chu_moment3
{
    
    abstract class BaseClassOfShapes
    {  
        // Set properties 
        protected double _side { get; set; }     
        protected double Area { get; set; }
        protected double Perimeter { get; set; }
        protected string Name { get; set; }
 
        // Abstract method (does not have a body)
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string getFigureNam();

    }
}