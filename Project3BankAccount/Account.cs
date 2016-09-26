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
        public double acctBalance = 0;
        public int userWithdraw;
        public int userDeposit;


        //properties

        public string AcctName { get; set; }
        public string AcctNumber { get; set ; }
        private double AcctBalance { get; set; }
       
            
            
            //methods

        public virtual void Withdraw ()
        {
            Console.WriteLine("Please enter the amount you'd like to withdraw.");
            double userWithdraw = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + userWithdraw);
           
            acctBalance -= userWithdraw;

            


        } //end Withdraw method

        public virtual void Deposit()
        {
            Console.WriteLine("Please enter the amount you'd like to depsit.");
            double userDeposit = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + userDeposit);

            acctBalance += userDeposit;
            
                  
       } //end Withdraw method



    }
}
