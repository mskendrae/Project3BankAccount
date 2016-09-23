using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Account
    {

        //This is the account class for Gringots Wizarding Bank and defines the common
        //traits for all accounts for the account holder.


         //fields
        private string acctName;
        private string acctNumber;
        private string acctType;
        private double acctbalance;

        //properties




        //contructors

        public Account(string acctName, string acctNumber, string acctType)
        {
            this.acctName = acctName;
            this.acctNumber = acctNumber;
            this.acctType = acctType;


        }

        //methods

        public double WithdrawalGold(double totalBalance, string acctType)
        {
            double removeGold = 

        }



    }
}
