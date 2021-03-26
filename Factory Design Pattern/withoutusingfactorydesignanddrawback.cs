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
    class Client
    {
        static void Main(string[] args)
        {
            string cardtype = "Money Bank";
            CreditCard Carddetails = null;
            if(cardtype!=null)
            {
                if(cardtype=="Money Bank")
                {
                    Carddetails = new MoneyBank();
                }
                else if(cardtype=="Platinum")
                {
                    Carddetails = new Platinum();
                }
                else if(cardtype=="Titanium")
                {
                    Carddetails = new Titanium();
                }

                Console.WriteLine("Card name: "+Carddetails.GetCreditcardName());
                Console.WriteLine("Card Limit "+Carddetails.GetCreditLimit());
                Console.WriteLine("Card Charge " + Carddetails.GetCreditCharge());
                
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
        }
       
    }
}

/*ekhane client class prottek ta credit card er sub class er sate tightly coupled amdr jodi sub class e change korte hy amdr client eta affect porbe abar amdr knu ekta new card class
 *jog korle amdr client e if else diye kaj korte hobe ajonno amra factory class use korbo jar mddhe amra only changes gula korbo bt client e tar knu change kora lagbe na
 *tobe ekta drawback holo factory class abar onno class er sate tightly coupled 
 */


