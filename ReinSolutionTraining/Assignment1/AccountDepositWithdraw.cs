using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolutionTraining.Assignment1
{
    class AccountDepositWithdraw
    {
        /*      8.	Create a class Account with member Variable: 
      long account No, String customer Name ,balance
      Make them public.
      Create default constructor assign new value to all variables and print I am in default constructor.
      Create constructor which takes all arguments and assigns those values to the member variables and print I am in parameterized 
        constructor.
      Create properties

      Methods –

      void deposit amount
      withdraw () to withdraw amount
       check_balance() to check balance*/
        String name;
        long number;
        long balance;

        void deposit()
        {
            Console.WriteLine("deposit money:");
        }
        void withdraw()
        {
            Console.WriteLine("withdraw money:");
        }
        void check_balance()
        {
            Console.WriteLine("check balance");
        }
        public AccountDepositWithdraw(string name, long number, long balance)
        {
            this.Name = name;
            this.Number = number;
            this.Balance = balance;
            Console.WriteLine("I am in parameterized constructer");
        }

        public string Name { get => name; set => name = value; }
        public long Number { get => number; set => number = value; }
        public long Balance { get => balance; set => balance = value; }

        static void Main(string[] args)
        {

        }
    }
}
