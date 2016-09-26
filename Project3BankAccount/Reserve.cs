using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Reserve:Account
    {
        //This is muggle worlds Checking account - WE dont have "checks"
        //all monies are in wizard world gold 

      //fields

        public double reserveBalance = 200000;
        private string acctType = "reserve";

        //properties

        private double ReserveBalance { get; set; }
        public string Type { get; set; }

        //constructor 

        public Reserve()
        {
            //this is empty on purpose
        }



        //methods

        public void CurrentReserveBalance()
        {
            Console.WriteLine("Your Reserve account balance is " + reserveBalance);
            Console.WriteLine();
            Console.WriteLine();

        }

        public override void Withdraw(Account reserveAccount)
        {
            base.Withdraw(reserveAccount);
            this.reserveBalance = reserveBalance - userWithdraw;

            Console.WriteLine("Your new balance Spend is " + "$" + this.reserveBalance);
            Console.WriteLine();
            Console.WriteLine();

            StreamWriter withdraw = new StreamWriter("reserve.txt", true);
            withdraw.WriteLine(DateTime.Now + " - $" + userWithdraw + " $" + this.reserveBalance);
            withdraw.Close();

        } //end Withdraw method

        public override void Deposit(Account reserveAccount)
        {
            base.Deposit(reserveAccount);
            this.reserveBalance = reserveBalance + userDeposit;

            Console.WriteLine("Your new balance is Spend " + "$" + this.reserveBalance);
            Console.WriteLine();
            Console.WriteLine();
            StreamWriter withdraw = new StreamWriter("reserve.txt", true);
            withdraw.WriteLine(DateTime.Now + " + $" + userDeposit + " $" + this.reserveBalance);
            withdraw.Close();

        } //end deposit method


    }//end Reserve Class
} //end namespace