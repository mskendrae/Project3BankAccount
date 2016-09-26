using Project3BankAccount;
using System;
using System.IO;
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

        public double spendBalance = 100000;
        

        //properties

        private double SpendBalance { get; set; }
        
        
        //constructor 

        public Spend()
        {
            //this is empty on purpose
        }

            
       
        //methods

        public void CurrentSpendBalance()
        {
            Console.WriteLine("Your Spend account balance is " + spendBalance);
            Console.WriteLine();
            Console.WriteLine();

        }

        public override void Withdraw(Account spendAccount)
        {
            base.Withdraw(spendAccount);
            this.spendBalance = spendBalance - userWithdraw;
             
            Console.WriteLine("Your new balance Spend is " + "$" + this.spendBalance);
            Console.WriteLine();
            Console.WriteLine();
            
            

        } //end Withdraw method

        public override void Deposit(Account spendAccount)
        {
            base.Deposit(spendAccount);
            this.spendBalance = spendBalance + userDeposit;
          
            Console.WriteLine("Your new balance is Spend " + "$" + this.spendBalance);
            Console.WriteLine();
            Console.WriteLine();

        } //end Withdraw method



    }//end class
}//end namespace
