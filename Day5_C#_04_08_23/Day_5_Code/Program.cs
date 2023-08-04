using System;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int consumernumber = Convert.ToInt32(Console.ReadLine());
            //String consumername = Console.ReadLine();
            //int curreading = Convert.ToInt32(Console.ReadLine());
            //int prevreading = Convert.ToInt32(Console.ReadLine());
            //String consumertype = Console.ReadLine();

            //ElectricReading electricReading = new ElectricReading(1234, "Sanjai", 10000, 8000, "Commercial");
            //int billamt = electricReading.CalculateBill();

            //    Console.WriteLine($"Bill: " + $"{electricReading.consumernumber}" + $"{electricReading.consumername}" + $"{billamt}");
            // Create an instance of the BankAccount class
            BankAccount bankaccount = new BankAccount(10432, "Sanjai");

            // Deposit
            Console.Write("Enter the amount to deposit: Rs.");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            int depositedAmount = bankaccount.amountDeposit(depositAmount);
            if (depositedAmount > 0)
            {
                Console.WriteLine($"Rs.{depositedAmount} deposited successfully.");
            }

            // Withdraw
            Console.Write("Enter the amount to withdraw: Rs.");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            int withdrawnAmount = bankaccount.amountWithdraw(withdrawAmount);
            if (withdrawnAmount > 0)
            {
                Console.WriteLine($"Rs.{withdrawnAmount} withdrawn successfully.");
            }

            // Display final account details
            Console.WriteLine($"Account number {bankaccount.Account_number} is handled by account Holder {bankaccount.Account_holdername} contains the balance of Rs.{bankaccount.Account_balance}");
        }
    }
}
