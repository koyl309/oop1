using System;

namespace _2pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Miscevist misc = new Miscevist();

            Console.WriteLine($"Рельєф: {misc.Relief}, Площа: {misc.Ploscha}, Населення: {misc.Naselennya}");
            misc.AnalyzeRelief();

            Console.WriteLine("\nВідредаговано:");
            misc.EditMiscevist("гірський", 123.7, 2468);
            misc.AnalyzeRelief();

            Console.ReadLine();
        }
    }
}
