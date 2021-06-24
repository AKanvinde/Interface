using System;

namespace OOP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            double CurrBal = obj.GetCurrentAccountBalance();
            double SavBal = obj.GetSavingAccountBalance();

            Console.WriteLine("Current Account Balance is $" +CurrBal);
            Console.WriteLine("Saving Account Balance is $" + SavBal);
            Console.ReadLine();
        }
    }
}
