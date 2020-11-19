//Acest program simuleaza functionarea unui aparat de vanzari
//Se pot introduce 3 tipuri de monede : 5 / 10 si 25
//Daca se introduce o suma de bani mai mare decat costul produsului, programul poate sa dea rest sau sa retina diferenta pentru o urmatoare achizitie
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
            if ((suma != 5) && (suma != 10) && (suma != 25))            // daca se introduce o valoare diferita de 5,10 sau 25
            {                                                           // se afiseaza eroare si se repeta enuntul de mai sus
                Console.WriteLine("Ati introdus o valoare gresita!");
                goto Start;
            }
            int rest = 0;
            Suma:
            while (suma < 20)                                          // se adauga banuti pana cand se ajunge la valoare produsului (20 coin)
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
            Console.WriteLine("Va rugam asteptati!");                        // peste 20 coin se elibereaza produsul si se calculeaza restul
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
            if (rest == 0)                                              //pentru restul 0 se repeta programul
                goto Start;
            if (rest == 5)                                              //pentru rest  = 5, 10, 15 sau 20: se elibereaza restul
            {                                                           // 1: se elibereaza restul
                suma = Rest1.FiveCoin();                                // sau
                if (suma == 0)                                          // 2: se retine restul pentru o urmatoare achizitie
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
                suma = Rest15.FifteenCoin();
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

