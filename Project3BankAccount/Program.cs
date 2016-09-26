using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is a bank accounting program for Gringots Wizards Bank
            //It contains 4 class to work with Spend, Reserve and Savings Accounts.
            //There is a menu program for the customer to get balances, add or withdrawal funds. 
            //Checking account is the same as Spend account
            
            Account mainAccount = new Account();
            Spend spendAccount = new Spend();
            Reserve reserveAccount = new Reserve();
            Savings savingsAccount = new Savings();

            int userChoice =1;
            do
            {

                // Main Menu
                Console.WriteLine("Welcome to Gringots Wizards Bank");
                Console.WriteLine("Please choose an option from the menu.");
                Console.WriteLine("1. Customer Account Information");
                Console.WriteLine("2. Customer Balance Information for all accounts");
                Console.WriteLine("3. Withdrawl Funds");
                Console.WriteLine("4. Deposit Funds");
                Console.WriteLine("5. Exit");

                userChoice = int.Parse(Console.ReadLine());
                //user Choice decions

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine(mainAccount.acctName);
                        Console.WriteLine(mainAccount.acctNumber);
                        break;

                    case 2:
                        Console.WriteLine("Please Choose which account you'd like a balance on");
                        Console.WriteLine("1. Spend Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");
                        int acctChoice = int.Parse(Console.ReadLine());
                        switch (acctChoice)
                        {
                            case 1:
                                spendAccount.CurrentSpendBalance();
                                break;
                            case 2:
                                reserveAccount.ReserveBalance();
                                break;
                            case 3:
                                savingsAccount.SavingsBalance();
                                break;

                        }//end AcctBalance switch

                        break;
                    case 3:
                        //Withdraw  menu and processing

                        Console.WriteLine("Please choose the account you would like to withdraw from:");
                        Console.WriteLine("1. Spend Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");
                        int withdrawChoice= int.Parse(Console.ReadLine());
                        switch (withdrawChoice)
                        {   case 1:

                                spendAccount.Withdraw();
                                break;
                            case 2:
                               
                                reserveAccount.Withdraw();
                                break;
                            case 3:

                                savingsAccount.Withdraw();
                                break;

                        }//end withdrawmenu
                        break;

                    case 4:
                        Console.WriteLine("Please choose the account you would like to depsit to:");
                        Console.WriteLine("1. Spend Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");
                        int depositChoice = int.Parse(Console.ReadLine());
                        switch (depositChoice)
                        {
                            case 1:
                                spendAccount.Deposit();
                                break;
                            case 2:
                                
                                reserveAccount.Deposit();
                                break;
                            case 3:
                                
                                savingsAccount.Deposit();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid number");
                                break;

                        }//end depmenu

                        break;

                    case 5:
                        Console.WriteLine("Thank you for choosing Gringots Wizards Bank.");
                        Console.WriteLine("We appreaciate your business and hope you return soon.");
                        
                        Console.ReadLine();                     
                        Environment.Exit(0);
                      
                        break;
                   default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }//end main menu switch

            } while (true);


        }//end class
    }//end namespace
}//end program
