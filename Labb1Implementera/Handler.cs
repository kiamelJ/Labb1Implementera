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
            Console.WriteLine("3) Display credit card options");
            Console.WriteLine("4) Exit");

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
                    DisplayAllCards();             
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        public static void DisplayAllCards()
        {
            //Factory Method. Här displayar vi de olika korten för användaren.
            Console.WriteLine("---Here are our different cards that we offer---\r\n");

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
            //Strategy Pattern. Här använder vi oss av algoritmen som vi gjorde i 
            //StrategyWithdraw.
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
            //Strategy Pattern. Här använder vi oss av algoritmen som vi gjorde i 
            //StrategyWithdraw.
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
                //Singleton Pattern. Vid felaktig inmatning skapas en instans av Singletonklassen och vi ropar på
                //ErrorMessage som displayar felmeddelande.
                Singleton.Instance.ErrorMessage();
                Console.ReadLine();
            }
        }
    }
}
