using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RealLifeExampleDelegates
{

    public interface CreditCard
    {
        public string GetCreditcardName();
        public int GetCreditLimit();
        public int GetCreditCharge();
    }

    public class MoneyBank: CreditCard
    {
        public string GetCreditcardName()
        {
            return "Money Bank";
        }
        public int GetCreditLimit()
        {
            return 15000;
                
        }

        public int GetCreditCharge()
        {
            return 300;
        }
    }


    public class Platinum : CreditCard
    {
        public string GetCreditcardName()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 25000;

        }

        public int GetCreditCharge()
        {
            return 500;
        }
    }

    public class Titanium : CreditCard
    {

        public string GetCreditcardName()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 35000;

        }

        public int GetCreditCharge()
        {
            return 1000;
        }
    }

    public class CreditFactory
    {
        
        public static CreditCard  CardType(string c)
        {
            
            CreditCard cd = null;
            if(c=="Money Bank")
            {
                cd = new MoneyBank();
                
            }
            else if (c=="Platinum")
            {
                cd = new Platinum();
            }
            else if(c=="Titanium")
            {
                cd = new Titanium();
            }

            return cd;
        }

        
    }
    class Client
    {
        static void Main(string[] args)
        {
            CreditCard cd = CreditFactory.CardType("Platinum");
            Console.WriteLine("Card Name: " + cd.GetCreditcardName());
            Console.WriteLine("Credit Limit: " + cd.GetCreditLimit());
            Console.WriteLine("CreditCahrge: " + cd.GetCreditCharge());
        }

       
    }
}

/* ekhane amra client class e only ki typer card sudu seta nicchi baki ja ase factory class e kore dicche
 * factory design dorkar hy object k jokhn subclass theke extended kora hobe, jodi jana na thake kotogulu subclass create korte hobe
 * product implementation jodi change kora lage product er change e client k somossa na koraa
 * */


