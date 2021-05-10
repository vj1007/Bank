using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Ioperations accCurr = new Current();
            Ioperations accSav = new Savings();
            Ioperations accRecur = new Recurring();
            accCurr.Deposit();
            accCurr.Withdraw();
            accCurr.Balance();
            accSav.Deposit();
            accSav.Withdraw();
            accSav.Balance();
            accRecur.Deposit();
            accRecur.Withdraw();
            accRecur.Balance();
            Console.WriteLine("Hello World!");
        }
    }
}
