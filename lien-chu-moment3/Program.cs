using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lien_chu_moment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {   //Create an interface for users to choose the options. 
                    Console.Clear();
                    Console.WriteLine("\n\t\t\n\t\tWelcome to Figure Area and Perimeter Calculation\t\t\n\t\tPlease navigate through the menu by typing a number. ");
                    Console.WriteLine("\t\t\n\t\t(1): Circle\n\t\t\n\t\t(2): Triangle\n\t\t\n\t\t(3): Square\n\t\t\n\t\t(4): Rectangle\n\t\t\n\t\t(0): End dialougue");

                    char input = ' '; //Creates the character input to be used with the switch-case below.
                    try
                    {
                        Console.Write("\t\t\n\t\tPlease enter your choice  between (1) - (4) or press (0) to exit: ");
                        input = Console.ReadLine()[0]; //Identify the first char in input line. 
                    }
                    catch (IndexOutOfRangeException) //Catch Exception like if the input line is empty, then ask the users for some input.
                    {
                        Console.WriteLine("\t\t\n\t\tPlease enter a number between (1) - (4) or enter 0 to exit the application! Hit any key to continue. ");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (input > '4') //If the input number is not match, ask the users for some input.
                    {
                        Console.WriteLine("\t\t\n\t\tThis number is not availabl. Please enter a number between (1) - (4) or press (0) to exit the application! Hit any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        switch (input)//Switch case for execution according to the input number.
                        {
                            case '0':
                                return;
                            case '1':
                                circleCalculation(); //Nav to method circleCalculation().
                                break;
                            case '2':
                                triangleCalculation();//Nav to method triangleCalculation().
                                break;
                            case '3':
                                squareCalculation();//nav to method squareCalculation().
                                break;
                            case '4':
                                rectangleCalculation();//nav to method rectangleCalculation().
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            #region 1. Circle
            void circleCalculation() //Method for circle calculation.
            {
                // Create a variable for convert to type double.
                double r = 1.0;
                // Create a while loop for keeping ask user until getting a valid input.
                bool repeat = true;
                while (repeat)
                {
                    try
                    {   // Ask the user for the radius as a parameter.
                        Console.Write("\t\t\n\t\tPlease enter the radius in cm : ");
                        string radiusOfCircle = Console.ReadLine();
                        // Convert the input type from string to double.
                        double.TryParse(radiusOfCircle, out r);
                        // If the input is not available, then ask the users to enter again parameter.
                        if (r <= 0)
                        {
                            Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                            Console.ReadLine();
                        }
                        // If the input is available, execute the next code.
                        else
                        {
                            repeat = false;
                        }
                    }
                    //Catch Exception like if the input line is empty, then ask the users for some input.
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                        Console.ReadLine();
                    }
                }
                // Create a Circle object with the input parameter
                Circle myCircle = new Circle(r);
                // print out the method getArea.
                Console.WriteLine("\n\t\t\n\t\tArea of circle is: " + Math.Round(myCircle.getArea(), 2) + "cm.");
                // print out the method getPerimeter.
                Console.WriteLine("\t\t\n\t\tPerimeter of circle is: " + Math.Round(myCircle.getPerimeter(), 2) + "cm.");
                // print out  the method getFigureNam.
                Console.WriteLine("\t\t\n\t\t" + myCircle.getFigureNam());
                Console.WriteLine("\t\t\n\t\tHit any key to continue.");
                Console.ReadLine();
            }
            #endregion

            #region 2. Ask User For Valid Input
            double askUserForValidInput(char side)   // Method for asking the user for valid input with a parameter for different sides.
            {
                // Create a while loop for keeping ask user until getting a valid input.
                while (true)
                {
                    // Create a variable for convert to type double.
                    double sideOfLength = 0.0;
                    // Ask the user for the length of the side.
                    Console.Write("\t\t\n\t\tPlease enter the length of side " + side + " of the triangle in cm : ");
                    string s = Console.ReadLine();
                    // Convert the input type from string to double.
                    double.TryParse(s, out sideOfLength);
                    // If the input is available, then return value and exit this method.
                    if (sideOfLength > 0)
                    {
                        return sideOfLength;
                    }
                    // If the input is not available, print out the message and go back to the beginning of this loop.
                    else
                    {
                        Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                        Console.ReadLine();
                    }
                }
            }
            #endregion

            #region 3. Triangle
            void triangleCalculation() // Method for Triangle calculation.
            {
                // Create 3 variables for convert to type double.
                double s1 = 0.0;
                double s2 = 0.0;
                double s3 = 0.0;
                try
                {
                    s1 = askUserForValidInput('A');
                    s2 = askUserForValidInput('B');
                    s3 = askUserForValidInput('C');           
                }
                catch (IndexOutOfRangeException) //Catch Exception like if the input line is empty, then ask the users for some input.
                {
                    Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                    Console.ReadLine();
                    return;
                }
                // Create a Triangle object with 3 parameters.
                Triangle myTriangle = new Triangle(s1, s2, s3);
                // print out the method getArea.
                Console.WriteLine("\n\t\t\n\t\tArea of triangle is: " + Math.Round(myTriangle.getArea(), 2) + "cm.");
                //  print out the method getPerimeter.
                Console.WriteLine("\t\t\n\t\tPerimeter of triangle is: " + Math.Round(myTriangle.getPerimeter(), 2) + "cm.");
                //  print out  the method getFigureNam.
                Console.WriteLine("\t\t\n\t\t" + myTriangle.getFigureNam());
                Console.WriteLine("\t\t\n\t\tHit any key to continue.");
                Console.ReadLine();
            }
            #endregion

            #region 4. Square
            void squareCalculation() //Method for Square calculation.
            {
                // Create a variable for convert to type double.
                double s1 = 1.0;
                    try
                    {
                        s1 = askUserForValidInput('A');
                    }
                    catch (IndexOutOfRangeException) //Catch Exception like if the input line is empty, then ask the users for some input.
                    {
                        Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                        Console.ReadLine();
                    }
                // Create a Square object with 1 parameter.
                Square mySquare = new Square(s1);
                // print out the method getArea.
                Console.WriteLine("\n\t\t\n\t\tArea of square is: " + Math.Round(mySquare.getArea(), 2) + "cm.");
                // print out the method getPerimeter.
                Console.WriteLine("\t\t\n\t\tPerimeter of square is: " + Math.Round(mySquare.getPerimeter(), 2) + "cm.");
                // print out  the method getFigureNam.
                Console.WriteLine("\t\t\n\t\t" + mySquare.getFigureNam());
                Console.WriteLine("\t\t\n\t\tHit any key to continue.");
                Console.ReadLine();
            }
            #endregion

            #region 5. Rectangle
            void rectangleCalculation() //Method for Rectangle calculation.
            {
                // Create 2 variables for convert to type double.
                double s1 = 1.0;
                double s2 = 1.0;               
                    try
                    {   // Ask the user for the 2 sides as parameters.
                        s1 = askUserForValidInput('A');
                        s2 = askUserForValidInput('B');
                    }
                    catch (IndexOutOfRangeException) //Catch Exception like if the input line is empty, then ask the users for some input.
                    {
                        Console.WriteLine("\t\t\n\t\tThis input is not available! Please try again! ");
                        Console.ReadLine();
                    }
                // Create a Rectangle object with 2 parameters.
                Rectangle myRectangle = new Rectangle(s1, s2);
                // print out the method getArea.
                Console.WriteLine("\n\t\t\n\t\tArea of rectangle is: " + Math.Round(myRectangle.getArea(), 2) + "cm.");
                // print out the method getPerimeter.
                Console.WriteLine("\t\t\n\t\tPerimeter of rectangle is: " + Math.Round(myRectangle.getPerimeter(), 2) + "cm.");
                // print out  the method getFigureNam.
                Console.WriteLine("\t\t\n\t\t"+myRectangle.getFigureNam());             
                Console.WriteLine("\t\t\n\t\tHit any key to continue.");
                Console.ReadLine();
            }
            #endregion

        }
    }
}
