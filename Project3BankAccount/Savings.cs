using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Savings:Account
    {


        //This is muggle worlds Checking account - WE dont have "checks"
        //all monies are in wizard world gold 

        //fields

        public double savingsBalance = 300000;
        private string acctType = "savings";

        //properties

        private double SavingsBalance { get; set; }
        private string Type { get; set; }


        //constructor 

        public Savings()
        {
            //this is empty on purpose
        }



        //methods

        public void CurrentSavingsBalance()
        {
            Console.WriteLine("Your Savings account balance is " + savingsBalance);
            Console.WriteLine();
            Console.WriteLine();

        }

        public override void Withdraw(Account savingsAccount)
        {
            base.Withdraw(savingsAccount);
            this.savingsBalance = savingsBalance - userWithdraw;

            Console.WriteLine("Your new balance Spend is " + "$" + this.savingsBalance);
            Console.WriteLine();
            Console.WriteLine();



        } //end Withdraw method

        public override void Deposit(Account savingsAccount)
        {
            base.Deposit(savingsAccount);
            this.savingsBalance = savingsBalance + userDeposit;

            Console.WriteLine("Your new balance is Spend " + "$" + this.savingsBalance);
            Console.WriteLine();
            Console.WriteLine();

        } //end Withdraw method


    }//end savings class

}//end namespace
