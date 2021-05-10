using System;

namespace Bank
{
    public class Savings : Ioperations
    {
        int b = 1000;
        public void Deposit(){
            int a;
            Console.WriteLine("Enter amount to be deposited");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount Deposited: {0}",a);
        }
        public void Withdraw(){
            int a;
            Console.WriteLine("Enter amountn to be withdrawn");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount Withdrawn {0}:",a);
        }
        public void Balance(){
            Console.WriteLine("Balance is: {0}",b);

        }

    }
}