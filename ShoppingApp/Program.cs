using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                amountFifty = amountTwenty = amountTen = amountFive = amountTwo = amountOne = 0;
                Console.Clear();
                Console.Write("Kolik utratil: ");
                string hasToPay = Console.ReadLine();

                Console.Write("Kolik zaplatil: ");
                string paid = Console.ReadLine();

                int hasToPayI = Convert.ToInt32(hasToPay);
                int paidI = Convert.ToInt32(paid);
                int i = 0;
                if (hasToPayI > paidI) { Console.WriteLine($"Nezaplatil jsi dostatek peněz. Musíš zaplatit ještě {hasToPayI - paidI}Kč"); break; }
                else if (hasToPayI == paidI) { Console.WriteLine("Zaplaceno!"); break; }
                else if (hasToPayI < paidI) { i =  ReturningMoney(paidI - hasToPayI);  }

                Console.WriteLine($"Vráceno {paidI - hasToPayI} ve formě {amountFifty}x 50 Kč, {amountTwenty}x 20 Kč, {amountTen}x 10 Kč, {amountFive}x 5 Kč, {amountTwo}x 2 Kč, {amountOne}x 1 Kč!");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        static int amountFifty = 0, amountTwenty = 0, amountTen = 0, amountFive = 0, amountTwo = 0, amountOne = 0;
        static int ReturningMoney(int hasToPayI)
        {
           

            if(hasToPayI >= 50)
            {
                amountFifty = hasToPayI / 50;
                hasToPayI -= (amountFifty * 50);
            }
            else if (hasToPayI >= 20)
            {
                amountTwenty = hasToPayI / 20;
                hasToPayI -= (amountTwenty * 20);
            }
            else if (hasToPayI >= 10)
            {
                amountTen = hasToPayI / 10;
                hasToPayI -= (amountTen * 10);
            }
            else if (hasToPayI >= 5)
            {
                amountFive = hasToPayI / 5;
                hasToPayI -= (amountFive * 5);
            }
            else if (hasToPayI >= 2)
            {
                amountTwo = hasToPayI / 2;
                hasToPayI -= (amountTwo * 2);
            }
            else if (hasToPayI == 1)
            { amountOne = hasToPayI; return hasToPayI; }
            else
            {
                return 0;
            }
            return ReturningMoney(hasToPayI);
        }
    }
}
