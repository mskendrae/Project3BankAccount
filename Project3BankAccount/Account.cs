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
        public int userWithdraw;
        public int userDeposit;


        //properties

        public string AcctName { get; set; }
        public string AcctNumber { get; set ; }



        //methods

        public void CustomerDisplay()
        {
            Console.WriteLine("Here is your account information");
            Console.WriteLine("Account Holder: " + this.acctName);
            Console.WriteLine("Account Number: " + this.acctNumber);

            Console.WriteLine();
            Console.WriteLine();
        }


            //withdraw Method
        public virtual void Withdraw(Account currentAccount)
        {
            Console.WriteLine("Please enter the amount you'd like to withdraw.");
            this.userWithdraw = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + this.userWithdraw);

           
        }//end Withdraw method


        //Deposit Method
        public virtual void Deposit(Account currentAccount)
        {
            Console.WriteLine("Please enter the amount you'd like to depsit.");
            this.userDeposit = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + this.userDeposit);
              
       } //end Withdraw method



    }
}
