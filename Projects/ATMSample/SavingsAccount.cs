using System;
using System.Collections.Generic;
using System.Text;

namespace ATMforCsharp
{
    class SavingsAccount
    {
        public double accountSTotal;
        public double bonusAmount;

        public SavingsAccount (double accountsavings)
        {
            this.accountSTotal = accountsavings;
        }
        void savingswithdrawl(double total)
        {
            if (this.accountSTotal >= total)
            {
                this.accountSTotal -= total;
            }
            else
            {
                double requiredAmount = total - this.accountSTotal;
                throw new InsufFund(requiredAmount);
            }
        }
        void savingsdeposit(double total)
        {
            //Adds to the current amount in
            this.accountSTotal += total;
        }
        void transfer(CheckingAccount withdrawAcc, SavingsAccount savingsAcc, double total)
        {
            if (withdrawAcc.accountTotal >= total)
            {
                withdrawAcc.accountTotal -= total;
                savingsAcc.accountSTotal += total;
            }
        }
        double balance()
        {
            return accountTotal;
        }
    }
}
