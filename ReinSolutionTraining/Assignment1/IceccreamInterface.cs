using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolutionTraining.Assignment1
{
    interface IIcecream
    {
        public void eat();
    }
    interface IJuice
    {
        public void drink();
    }

    class Mastani : IIcecream, IJuice
    {
        public void eat()
        {
            Console.WriteLine("Am Eating Mastani");
        }
        public void drink()
        {
            Console.WriteLine("Am Drinking Mastani");
        }
    }
    class IcecreamInterface
    {
        static void Main(string[] args)
        {
            Mastani m1 = new Mastani();
            m1.eat();
            m1.drink();
        }
    }
}

