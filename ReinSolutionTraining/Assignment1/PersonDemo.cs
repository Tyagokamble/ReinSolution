using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolutionTraining.Assignment1
{
    public class Vehicle
    {
        protected int vid;
        protected string vname;

        public Vehicle(int id, string name)
        {
            vid = id;
            vname = name;
        }
        Vehicle()
        {

        }

    }
    public class Person : Vehicle
    {
        int pid;
        string pname;
        Vehicle v;
        public Person(int id, string name, int vid, string vname) : base(vid, vname)
        {
            pid = id;
            pname = name;
        }
        public void show()
        {
            Console.WriteLine("" +
                "\nPerson Id    : " + pid +
                "\nPerson Name  : " + pname +
                "\nVehicle Id   : " + vid +
                "\nVehicle Name : " + vname
                );
        }
    }
    class PersonDemo
    {
        static void Main(string[] args)
        {
            Person[] P = new Person[4];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Person Id    : ");
                int ppid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Person Name  : ");
                string ppname = Console.ReadLine();
                Console.WriteLine("Enter Vehicle Id   : ");
                int vvid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Vehicle Name : ");
                string vvname = Console.ReadLine();

                P[i] = new Person(ppid, ppname, vvid, vvname);

            }
            for (int i = 0; i < 2; i++)
            {
                P[i].show();
            }

        }
    }
}

