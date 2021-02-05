using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("ORCL", "Oracle Corporation", 34.5M, 34.35M);
            Console.WriteLine("The price-change percent: {0}", stock.GetChangePercent());
            Console.ReadKey();
        }
    }
}