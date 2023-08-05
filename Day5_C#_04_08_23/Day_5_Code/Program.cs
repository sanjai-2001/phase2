using SampleLibrary;
using System;
using SampleProgram;


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

            //// Create an instance of the BankAccount class
            //BankAccount bankaccount = new BankAccount(10432, "Sanjai");

            //// Deposit
            //Console.Write("Enter the amount to deposit: Rs.");
            //int depositAmount = Convert.ToInt32(Console.ReadLine());
            //int depositedAmount = bankaccount.amountDeposit(depositAmount);
            //if (depositedAmount > 0)
            //{
            //    Console.WriteLine($"Rs.{depositedAmount} deposited successfully.");
            //}

            //// Withdraw
            //Console.Write("Enter the amount to withdraw: Rs.");
            //int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            //int withdrawnAmount = bankaccount.amountWithdraw(withdrawAmount);
            //if (withdrawnAmount > 0)
            //{
            //    Console.WriteLine($"Rs.{withdrawnAmount} withdrawn successfully.");
            //}

            //// Display final account details
            //Console.WriteLine($"Account number {bankaccount.Account_number} is handled by account Holder {bankaccount.Account_holdername} contains the balance of Rs.{bankaccount.Account_balance}");

            Book[] arr = { new Book(101, "Microprocessor", "Harsha", true), new Book(102, "DSP", "Sanjai", true), new Book(103, "Java", "JK", true), new Book(104, "C#", "Yogi", false) };
            Library library = new Library(arr);
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the title of the book to borrow");
                    string title = Console.ReadLine();
                    library.BorrowBook(title);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the title of the book to return");
                    string title = Console.ReadLine();
                    library.ReturnBook(title);
                }
                else if (choice == 3)
                {
                    library.DisplayBookDetails();
                }
                else if (choice == 4)
                {
                    break;
                }
            }
        }
    }
    }

