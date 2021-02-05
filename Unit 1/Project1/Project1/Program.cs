using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4M, 40M);
            Rectangle rectangle1 = new Rectangle(3.5M, 35.9M);

            Console.WriteLine(rectangle);
            Console.WriteLine(rectangle1);
            Console.ReadKey();
        }
    }
}
