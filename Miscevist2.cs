using System;
using System.Collections.Generic;
using System.Text;

namespace _2pr
{
    class Miscevist
    {
        private string relief;
        private double ploscha;
        private int naselennya;

        public Miscevist()
        {
            Relief = "рівнина";
            Ploscha = 0.0;
            Naselennya = 0;
        }

        public string Relief
        {
            get => relief;
            set => relief = value;
        }

        public double Ploscha
        {
            get => ploscha;
            set => ploscha = value;
        }

        public int Naselennya
        {
            get => naselennya;
            set => naselennya = value;
        }

        public void EditMiscevist(string relief, double ploscha, int naselennya)
        {
            this.relief = relief;
            this.ploscha = ploscha;
            this.naselennya = naselennya;

            Console.WriteLine($"Рельєф: {this.relief}");
            Console.WriteLine($"Площа: {this.ploscha} км^2");
            Console.WriteLine($"Населення: {this.naselennya} осіб");
        }

        public void AnalyzeRelief()
        {
            if (relief.ToLower() == "рівнина")
                Console.WriteLine("Рівнинна місцевість.");
            else if (relief.ToLower() == "гірський")
                Console.WriteLine("Гірська місцевість.");
            else
                Console.WriteLine("err");
        }
    }
}
