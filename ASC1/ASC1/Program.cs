using System;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!");
            Console.WriteLine("Introduceti numarul de la pantof: ");

            string line;
            line = Console.ReadLine();

            int numarPantof;

            try
            {
                numarPantof = int.Parse(line);
                Console.WriteLine("Aveti numarul {0} la pantof", numarPantof);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
