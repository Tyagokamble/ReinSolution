using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolutionTraining.Assignment1
{
    class AreaOfSquareRectangleAndCircle
    {
        public void area(double a)
        {
            Console.WriteLine("area of square:" + a * a);
        }
        public void area(int  a)
        {
            Console.WriteLine("area of circle:" + 3.14*a*a);
        }
        public void area(int l, int b)
        {
            Console.WriteLine("area of rectangle:" +2*l*b );
        }
        static void Main(string[] args)
        {
            AreaOfSquareRectangleAndCircle a = new AreaOfSquareRectangleAndCircle();
            a.area(5);
            a.area(5,5);
            a.area(8,6);


        }
    }
}
