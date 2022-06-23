using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolutionTraining.Assignment1
{
 /*   1.	Create class Teacher with following

    Tid,Tname,MobileNo
    Parameterized constructor
    abstract void salary()
•	Create class Hourlybased which is derived class from teacher with fields
     rate_per_hr,
    int hrs;
    Parameterized constructor
    void salary()
•	Create class SalaryBased which is derived class from teacher
    with fields
     int salary;
    Parameterized constructor

    void salary()
Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective salary method and also show runtime polymorphism
*/
    abstract class Teacher
    {
        protected int Tid;
        protected string Tname;
        protected long MobileNo;
        protected Teacher(int id, string name, long mobile)
        {
            Tid = id;
            Tname = name;
            MobileNo = mobile;

        }
        protected Teacher() { }
        public abstract void salary();
    }

    class HourlyBased : Teacher
    {
        int rate_per_hr;
        int hrs;

        public HourlyBased()
        {
        }

        public HourlyBased(int id, string name, long mob, int rateperhour, int hr) : base(id, name, mob)
        {
            rate_per_hr = rateperhour;
            hrs = hr;
        }

        public override void salary()
        {
            System.Console.WriteLine
                ("---HOURLY---\n" +
                "\nId    : " + this.Tid +
                "\nName  : " + this.Tname +
                "\nMobile: " + this.MobileNo +
                "\nSalary: " + (rate_per_hr * hrs)
                );
        }

    }

    class SalaryBased : Teacher
    {
        int sal;

        public SalaryBased()
        {

        }

        public SalaryBased(int id, string name, long mobile, int s) : base(id, name, mobile)
        {
            sal = s;
        }
        public override void salary()
        {
            System.Console.WriteLine
                ("---SALARY---\n" +
                "\nId    : " + this.Tid +
                "\nName  : " + this.Tname +
                "\nMobile: " + this.MobileNo +
                "\nSalary: " + (sal)
                );
        }
    }
    class HW_2_1_RuntimePolymorphism
    {

        static void Main(string[] args)
        {
            Teacher t1 = new SalaryBased(71, "Shivam", 9584652356, 10000);

            Teacher t2 = new HourlyBased(72, "Sandeep", 92745815425, 500, 10);
            Console.WriteLine("");
            t1.salary();
            Console.WriteLine("");
            t2.salary();



        }
    }

}
