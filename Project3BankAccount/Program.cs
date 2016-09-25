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

                                //get balance from spend class
                                break;
                            case 2:
                                //get balance from reserve class
                                break;
                            case 3:
                                //get balance from savings class
                                break;
                        }//end AcctBalance switch

                        break;
                    case 3:

                        Console.WriteLine("Please enter the amount you'd like to withdrawal.");

                        double userWithdraw = int.Parse(Console.ReadLine());
                        mainAccount.goldWithdraw = userWithdraw;
                        mainAccount.Withdraw();
                        Console.WriteLine(mainAccount.acctBalance);

                        break;

                    case 4:
                        Console.WriteLine("Please enter the amount you'd like to deposit.");

                        double userDeposit = int.Parse(Console.ReadLine());
                        mainAccount.addGold = userDeposit;
                        mainAccount.Deposit();
                        break;

                    case 5:
                        Console.WriteLine("Thank you for choosing Gringots Wizards Bank.");
                        Console.WriteLine("We appreaciate your business and hope you return soon.");
                        Console.WriteLine("Please enter 5 again to exit.");
                        int exitChoice = int.Parse(Console.ReadLine());

                        if (exitChoice == 5)
                        {
                            Environment.Exit(0);
                        }
                        
                        break;
                }//end main menu switch

            } while (userChoice > 4);


                Console.ReadLine();

        }//end class
    }//end namespace
}//end program
