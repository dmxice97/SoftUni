using System;

namespace _12._Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cvalue = double.Parse(Console.ReadLine());
            var currency = Console.ReadLine();
            var currency2 = Console.ReadLine();


            string usd = "USD";
            string eur = "EUR";
            string gbp = "GBP";
            string bgn = "BGN";
            double ValutenKurs = 0;
            double ValutenKurs1 = 0;

            if (currency == usd)
            {
                ValutenKurs = 1.79549;
            }
            else if (currency == eur)
            {
                ValutenKurs = 1.95583;
            }
            else if (currency == gbp)
            {
                ValutenKurs = 2.53405;
            }
            else
            {
                ValutenKurs = 1;
            }


            if (currency2 == usd)
            {
                ValutenKurs1 = 1.79549;
            }
            else if (currency2 == eur)
            {
                ValutenKurs1 = 1.95583;
            }
            else if (currency2 == gbp)
            {
                ValutenKurs1 = 2.53405;
            }
            else
            {
                ValutenKurs1 = 1;
            }

            var kraino = 0.0;

            if (currency2 == bgn)
            {
                kraino = (Cvalue * ValutenKurs) * ValutenKurs1;

            }
            else
            {
                kraino = (Cvalue * ValutenKurs) / ValutenKurs1;
            }


            Console.WriteLine(kraino.ToString("f2") + " " + currency2);



        }
    }
}
