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
        public string acctType = "spend";


        //properties

        private double SpendBalance { get; set; }
        public string Type { get; set; }
        
        
                
        //constructor 

        public Spend():base()
        {
            this.acctType = "Spend";
            this.spendBalance = 100000;
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
            StreamWriter withdraw = new StreamWriter("spend.txt", true);
            withdraw.WriteLine(DateTime.Now + " - $" + userWithdraw + " $" + this.spendBalance);
            withdraw.Close();


        } //end Withdraw method

        public override void Deposit(Account spendAccount)
        {
            base.Deposit(spendAccount);
            this.spendBalance = spendBalance + userDeposit;
          
            Console.WriteLine("Your new balance is Spend " + "$" + this.spendBalance);
            Console.WriteLine();
            Console.WriteLine();

            StreamWriter withdraw = new StreamWriter("spend.txt", true);
            withdraw.WriteLine(DateTime.Now + " + $" + userDeposit + " $"+ this.spendBalance);
            withdraw.Close();

        } //end Withdraw method



    }//end class
}//end namespace
