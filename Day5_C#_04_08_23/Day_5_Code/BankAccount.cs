using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram
{
    class BankAccount
    {
        private readonly int _account_number;
        private string accountholdername;
        private int accountbalance = 0;

        public BankAccount(int _account_number, string account_holdername)
        {
            this._account_number = _account_number;
            Account_holdername = account_holdername;
        }

        public int Account_number => _account_number;

        public string Account_holdername { get => accountholdername; set => accountholdername = value; }
        public int Account_balance { get => accountbalance; set => accountbalance = value; }

        public int amountDeposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Deposit amount must be greater than zero.");
                return -1;
            }
            else
            {
                Account_balance += amount;
                return Account_balance;
            }
        }


        public int amountWithdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Withdrawal amount must be greater than zero.");
                return -1;
            }
            else if (amount > Account_balance)
            {
                Console.WriteLine("Insufficient balance.");
                return -1;
            }
            else
            {
                Account_balance -= amount;
                return amount;
            }
        }

    }
}
