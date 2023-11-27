using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateWhatVariant.before
{
    internal class Pizaa
    {
        public virtual string Title => $"{nameof(Pizaa)}";
        public virtual decimal Price => 10m;

        private static void prepare()
        {
            Console.WriteLine("preparing....");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cook()
        {
            Console.WriteLine("Cooking....");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cut()
        {
            Console.WriteLine("Cutting....");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"the Title of the pizaa is: {Title}\n the price of the pizaa: {Price}";
        }

        public static Pizaa order(string type)
        {
            Pizaa pizaa;
            if (type == "Cheese")
            {
                pizaa = new Cheese();

            }
            else
            {
                pizaa = new Chicken();

            }

            prepare();
            Cook();
            Cut();
            return pizaa;
        }
    }
}
