using Labb1Implementera.ConcreteStrategies;
using Labb1Implementera.Factories;
using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    public class Handler
    {
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("----Welcome! What do you want to do today?----\r\n");
            Console.WriteLine("1) Withdraw Money");
            Console.WriteLine("2) Deposit Money");
            Console.WriteLine("3) Check Saldo");
            Console.WriteLine("4) Display credit card options");
            Console.WriteLine("5) Exit");

            Console.Write("\r\nYour choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Withdraw();
                    
                    return true;
                case "2":
                    Console.Clear();
                    Deposit();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Check Saldo");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.Clear();
                    DisplayAllCards();             
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        public static void DisplayAllCards()
        {
            var creditCard = new VisaFactory().CreateCard();
            if (creditCard != null)
            {
                Console.WriteLine($"Card Type: {creditCard.GetCreditCardType()}");
                Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit().ToString("c0")}");
                Console.WriteLine($"Annual Cost: {creditCard.GetAnnualCost().ToString("c0")}");
            }
            else
            {
                Console.WriteLine("Invalid card type");
            }

            Console.WriteLine("----------------------------");

            creditCard = new MasterCardFactory().CreateCard();
            if (creditCard != null)
            {
                Console.WriteLine($"Card Type: {creditCard.GetCreditCardType()}");
                Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit().ToString("c0")}");
                Console.WriteLine($"Annual Cost: {creditCard.GetAnnualCost().ToString("c0")}");
            }
            else
            {
                Console.WriteLine("Invalid card type");
            }

            Console.WriteLine("----------------------------");

            creditCard = new AmericanExpressFactory().CreateCard();
            if (creditCard != null)
            {
                Console.WriteLine($"Card Type: {creditCard.GetCreditCardType()}");
                Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit().ToString("c0")}");
                Console.WriteLine($"Annual Cost: {creditCard.GetAnnualCost().ToString("c0")}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid card type");
                Console.ReadLine();
            }
        }

        public static void Withdraw()
        {
            try
            {
                Console.WriteLine("Please enter amount to withdraw: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                var context = new StrategyContext();
                context.SetBalanceStrategy(new StrategyWithdraw());
                context.AccountAction(amount);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Singleton.Instance.ErrorMessage();
                Console.ReadLine();
            }          
        }

        public static void Deposit()
        {
            try
            {
                Console.WriteLine("Please enter amount to deposit: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                var context = new StrategyContext();
                context.SetBalanceStrategy(new StrategyDeposit());
                context.AccountAction(amount);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Singleton.Instance.ErrorMessage();
                Console.ReadLine();
            }
            //Console.WriteLine("Please enter amount to deposit: ");
            //decimal amount = Convert.ToDecimal(Console.ReadLine());
            //var context = new StrategyContext();
            //context.SetBalanceStrategy(new StrategyDeposit());
            //context.AccountAction(amount);
            //Console.ReadLine();
        }
    }
}
