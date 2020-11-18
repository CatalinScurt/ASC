using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatDeVanzari
{
    class Rest10
    {
        public static int TenCoin()
        {   Retry:
            Console.WriteLine("Rest: 10 coin");
            Console.WriteLine("^^^^^^^^^^^^^");
            Console.WriteLine("Pentru a retrage apasati tasta 1");
            Console.WriteLine("Pentru a continua cumparaturile apasati tasta 2");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Cei 10 coin au fost retrasi!");
                return 0;
            }
            if (answer == 2)
            {
                return 10;
            }
            if ((answer != 1) || (answer != 2))
            {
                Console.WriteLine("Ati apasat o tasta gresita!");
                goto Retry;
            }
            return 0;
        }
    }
}
