using System;

namespace AutomatDeVanzari
{
    class Program
    {
        static void Main(string[] args)
        { 
            Start:
            Console.WriteLine("");
            Console.WriteLine("Introduceti banuti (5 / 10 / 25)");
            Console.WriteLine("Aveti nevoie de 20 centi pentru a cumpara produsul!");
            int coin = int.Parse(Console.ReadLine());
            int suma = coin;
            if ((suma != 5) && (suma != 10) && (suma != 25))
            {
                Console.WriteLine("Ati introdus o valoare gresita!");
                goto Start;
            }
            int rest = 0;
            Suma:
            while (suma < 20)
            {
                Console.WriteLine("Sold disponibil = {0}", suma);
                Console.WriteLine("---------------------");
            Retry:
                Console.WriteLine("Mai adaugati {0} banuti pentru a putea achizitiona produsul!", 20 - suma);
                int addCoin = int.Parse(Console.ReadLine());
                if ((addCoin != 5) && (addCoin != 10) && (addCoin != 25))
                {
                    Console.WriteLine("Ati introdus o valoare gresita!");
                    goto Retry;
                }
                suma = suma + addCoin;
            }
            Console.WriteLine("Va rugam asteptati!");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("===============================");
            Console.WriteLine("|| Produsul a fost eliberat! ||");
            Console.WriteLine("===============================");
            Console.WriteLine(" ");
            rest = suma - 20;
            if (rest == 0)
                goto Start;
            if (rest == 5)
            {
                suma = Rest1.FiveCoin();
                if (suma == 0)
                    goto Start;
                if (suma == 5)
                    goto Suma;
            }
            if (rest == 10)
            {
                suma = Rest10.TenCoin();
                if (suma == 0)
                    goto Start;
                if (suma == 10)
                    goto Suma;
            }
            if (rest == 15)
            {
                suma = Rest15.FiveteenCoin();
                if (suma == 0)
                    goto Start;
                if (suma == 15)
                    goto Suma;
            }
            if (rest == 20)
            {
                suma = Rest20.TwentyCoin();
                if (suma == 0)
                    goto Start;
                if (suma == 20)
                    goto Suma;
            }
           
        } 

    }

}
/*Alternativa la if-uri :
            switch (rest)
            {
                case 0:
                    goto Start;
                case 5:
                    suma = Rest1.FiveCoin();
                    if (suma == 0)
                        goto Start;
                    if (suma == 5)
                        goto Suma;
                    break;
                case 10:
                    suma = Rest10.TenCoin();
                    if (suma == 0)
                        goto Start;
                    if (suma == 10)
                        goto Suma;
                    break;
                case 15:
                    suma = Rest15.FiveteenCoin();
                    if (suma == 0)
                        goto Start;
                    if (suma == 15)
                        goto Suma;
                    break;
                case 20:
                    suma = Rest20.TwentyCoin();
                    if (suma == 0)
                        goto Start;
                    if (suma == 20)
                        goto Suma;
                    break;
            }
            */

