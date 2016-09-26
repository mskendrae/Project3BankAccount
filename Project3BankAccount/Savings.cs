using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Savings: Account
    {

        //fields

        public new double acctBalance = 100000000;
       
       
        //properties

        private double AcctBalance { get; set; }
        
        
        //constructor 

        public Savings()
        {
            //this consctructor is supposed to be empty
        }

        //methods

        public void SavingsBalance()
        {
            Console.WriteLine("This is your Savings account balance " + "$" + this.acctBalance);
            Console.WriteLine();
            Console.WriteLine();
        }

        public override void Withdraw()
        {
            base.Withdraw();



        } //end Withdraw method

        public override void Deposit()
        {
            base.Deposit();
        

        } //end Withdraw method


    }//end savings class

}//end namespace
