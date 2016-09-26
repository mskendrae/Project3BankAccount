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

        public double spendBalance = 1000000;
        

        //properties

        private double SpendBalance { get; set; }
        
        
        //constructor 

        public Spend()
        {
           //left blank on purpose
        }

            
       
        //methods

        public void CurrentSpendBalance()
        {
            Console.WriteLine("Your Spend account balance is " + spendBalance);
            Console.WriteLine();
            Console.WriteLine();

        }

        public override void Withdraw()
        {
            base.Withdraw();
            spendBalance -= base.userWithdraw;
            double newBalance = spendBalance;
            Console.WriteLine("Your new balance Spend is " + "$" + newBalance);
            Console.WriteLine();
            Console.WriteLine();

        } //end Withdraw method

        public override void Deposit()
        {
            base.Deposit();
            spendBalance += base.userDeposit;
            double newBalance = spendBalance;
            Console.WriteLine("Your new balance is Spend " + "$" + newBalance);
            Console.WriteLine();
            Console.WriteLine();

        } //end Withdraw method



    }//end class
}//end namespace
