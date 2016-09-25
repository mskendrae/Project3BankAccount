using Project3BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Spend: Account
    //This is muggle worlds Checking account - WE dont have "checks"
    //all monies are in wizard world gold 

    {  //fields

        public double acctBalance = 1000000;
        public double goldWithdraw;
        public double addGold;

        //properties

        private double AcctBalance { get; set; }
        private double GoldWithdraw { get; set; }
        private double AddGold { get; set; }
        //constructor 


       
        //methods

        public void SpendBalance()
        {
            Console.WriteLine(this.acctBalance);

        }

        public override void Withdraw()
        {
            base.Withdraw();
            this.acctBalance -= goldWithdraw;


        } //end Withdraw method

        public override void Deposit()
        {
            base.Deposit();
            this.acctBalance += addGold;

        } //end Withdraw method



    }//end class
}//end namespace
