using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");
            int num1;
            int num2;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            MathsHelper helper = new MathsHelper();
            
            int x = helper.Add(num1, num2);
            Console.WriteLine("\nThe sum of " + num1 + " and " + num2 + " is " + x);
            Console.ReadKey();

            int y = helper.Subtract(num1, num2);
            Console.WriteLine("\nThe difference between " + num1 + " and" + num2 + "  is " + y);
            Console.ReadKey();
        }
    }

    public class MathsHelper
    {
        public MathsHelper() { }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
