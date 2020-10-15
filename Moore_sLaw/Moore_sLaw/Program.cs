using System;

namespace Moore_sLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                /*Enuntul problemei:După cât timp vom avea o putere de calcul de 100 de ori mai mare (procesoare de 100 de ori mai rapide), față de cât avem la un moment dat, la același preț. 
                 * Generalizare: după cât timp vom avea o puterea de calcul de n ori mai mare, la același preț (n este un număr natural).
                 * Rezolvare:
                 * Se considera x = timpul necesar pentru a se efectua n dublari
                 * Se considera n = de cate ori va fi mai mare puterea procesoarelor decat puterea acestora la un momentdat(n se introduce de la tastatura)
                 * =>2^x = n
                 * => x = log2(n)
                 * Dublarea fiind la 18 luni(1.5 ani) => forumla de calcul = log2(n) * 18
                 */

                Console.WriteLine("\t Moore's Law");

                string line;
                double x, ani, luni, zile;

                Console.WriteLine("De cate ori doriti ca puterea de calcul a procesoarelor sa fie mai mare decat puterea pe care o au acestea in acest moment?");
                line = Console.ReadLine();
                int n = int.Parse(line);

                x = Math.Log(n, 2) * 18;
                ani = Math.Truncate(x / 12);
                luni = Math.Truncate(x % 12);
                if ((luni <= 7 && luni % 2 == 1) || (luni >= 8 && luni % 2 == 0))    // calcul zile ramase pentru lunile din 31 de zile
                    zile = Math.Truncate((x % 12 - luni) * 30);
                else
                    zile = Math.Truncate((x % 12 - luni) * 31);                    // calcul zile ramase pentru lunile din 30 de zile

                Console.WriteLine("Va fi necesar {0} ani {1} luni si {2} zile pentru ca puterea de calcul a procesoarelor sa fie de {3} ori mai mare!", ani, luni, zile, n);


            }

        }
    }
}
