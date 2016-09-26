using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Reserve: Account
       {
        //fields

        public new double acctBalance = 50000;

        //properties

        private double AcctBalance { get; set; }
        
       
        //constructor 

        public Reserve()
        {
            //this consctructor is supposed to be empty
        }

        //methods

        public void ReserveBalance()
        {
            Console.WriteLine("This is your Reserve account balance "+ "$" + this.acctBalance);
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



    }//end Reserve Class
} //end namespace