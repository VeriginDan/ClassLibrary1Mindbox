using ClassLibrary1Mindbox;
using System.Runtime.CompilerServices;

namespace ClassLibrary1Mindbox
{
    
  /*  public delegate void ResultHandler(string message); // events for messaging
    public event ResultHandler? Notify;
    public void calculate_area(string user_input)
    {
        Figure figure = null;
        string[] subs = user_input.Split(' ');

        switch (subs.Length)
        {
            case 1: figure = new Disk(double.Parse(subs[0])); break;
            case 3: figure = new Triangle(new double[3]{ double.Parse(subs[0]), double.Parse(subs[1]), double.Parse(subs[0]) }); break;
            default: figure= null; break;
        }
        if (figure != null)
        {
            Console.WriteLine(figure.Area());
        }
        else
        {
            Console.WriteLine("Неверный тип фигуры");
        }
    }
  */
public abstract class Figure
    {
        
        public abstract double Area();
        public abstract bool isFigureReal();
    }

    public class Triangle : Figure
    {
        //public double length1, length2, length3;

        public Triangle(double[] sides) { this.sides = sides; }

        double[] sides;

        public override bool isFigureReal() // check for proper lengths of sides
        {
            byte max_position = 0;

            if (sides[0] == 0 || sides[1] == 0 || sides[2] == 0) // check that one side or more is zero
            {
              //  Notify?.Invoke("One or more sides is zero");   // send event that triangle not exist
                return false;
            }

            else if (max_position != 0) // swap positions of first and maximal elements
            {
                for (byte iter = 1; iter < 2; iter++) max_position = sides[iter] > sides[iter - 1] ? iter : max_position; // find position of maximal length
                double temp = sides[0];
                sides[0] = sides[max_position];
                sides[max_position] = temp;
            }

            return sides[0] < (sides[1] + sides[2]); // sum of two smaller sides of trinagle must be greater than the biggest one
        }

        override public double Area()
        {
            if (this.isFigureReal())
            {
                if (sides[0] * sides[0] == (sides[1] * sides[1] + sides[1] * sides[1]))
                    {
              //      Notify?.Invoke("There triangle is rightangled");
                    return 0.5 * sides[1] * sides[2];
                }
                else
                {
                    double semi_perimeter = (this.sides[0] + this.sides[1] + this.sides[2]) / 2;
                    return Math.Sqrt(semi_perimeter * (semi_perimeter - sides[0]) * (semi_perimeter - sides[1]) * (semi_perimeter - sides[2]));
                }
            }
            else
            {
       //         Notify?.Invoke("There is error in length of sides");   // send event that triangle not exist
                return 0;
            }
        }
    }

    public class Disk : Figure
    {
        public double radius;

        public Disk(double radius) { }

        public override bool isFigureReal() // check for value of radius
        {

            if (this.radius == 0) // check that one side or more is zero
            {
        //        Notify?.Invoke("radius must be not zero");   // send event that triangle not exist
                return false;
            }

            else return true;
        }

        override public double Area()
        {
            const double PI = 3.141592653589793;
            if (this.isFigureReal()) return PI * this.radius * this.radius;
            else return 0;
        }

    }

       
}
