using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNetApp192
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, students!!!");
            Console.WriteLine("Hello, students, 2nd time!!!");
            Console.WriteLine("Hello, students, 3nd time!!!");

            double x, y, z;

            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Pow(x / y, 3);
            Console.WriteLine("Z = " + z);
            Console.WriteLine("Z = {0}", z);
            Console.WriteLine($"Z = {z}");
        }

    }
}
