using System;
using System.Collections.Generic;
using System.Text;

namespace ATMforCsharp
{
    class CheckingAccount
    {
        public int count;
        public double accountTotal;
        public double extraCharge;

        public CheckingAccount(double accountBalance)
        {
            accountTotal = accountBalance;
        }
        void withdrawl(double total)
        {
            if(count >= 4)
            {
                extraCharge = 1.5;
                total += extraCharge;
            }
            if(this.accountTotal >= total)
            {
                this.accountTotal -= total;
                count++;
            }
            else
            {
                double requiredAmount = total - this.accountTotal;
                throw new InsufFund(requiredAmount);
            }
        }
        // Method for deposit
        void deposit(double total)
        {
            //Adds to the current amount in
            this.accountTotal += total;
        }

        void transfer(CheckingAccount withdrawAcc, SavingsAccount savingsAcc, double total)
        {
            if(withdrawAcc.accountTotal >= total)
            {
                withdrawAcc.accountTotal -= total;
                savingsAcc.accountSTotal += total;
            }
        }

        // Method to return Balance
        double balance()
        {
            return accountTotal;
        }

    }
}
