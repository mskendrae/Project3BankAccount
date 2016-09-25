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
        public string acctName = "Dumbledore";
        public string acctNumber = "777333";
        public double acctBalance = 1000000;
        public double goldWithdraw;
        public double addGold;
        
        //properties

        public string AcctName { get; set; }
        public string AcctNumber { get; set ; }
        private double AcctBalance { get; set; }
        private double GoldWithdraw { get; set; }
        private double AddGold { get; set; }


        //methods

        public virtual void Withdraw ()
        {
            this.acctBalance -= goldWithdraw;
            

        } //end Withdraw method

        public virtual void Deposit()
        {
            this.acctBalance += addGold;

        } //end Withdraw method



    }
}
