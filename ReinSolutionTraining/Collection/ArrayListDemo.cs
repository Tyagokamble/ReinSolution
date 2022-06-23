using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinSolutionTraining.Collection
{
    class Emp
    {
        string name;
        int a;

        public Emp(string name, int a)
        {
            this.name = name;
            this.a = a;
        }
    }

    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(90);
            al.Add(5);
            al.Add("omkar");
            al.Add("omkar");               // duplicates are allowed
            al.Add("omkar");
            al[0] = 80;                   //replace
            al.Add(new Emp("om", 50));

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            foreach (object ob in al)
            {
                Console.WriteLine(ob);
            }

            List<int> ll = new List<int>();
            ll.Add(90);
            ll.Add(45);
            ll.Add(67);
            ll.Add(20);


            Console.WriteLine(ll.Remove(45));

            foreach (int d in ll)
            {
                Console.WriteLine(d);
            }


           
        }
    }
}
    
      
          

        
       
   

