using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;

            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter any of the operations");

            Console.WriteLine("a ------ Addition");
            Console.WriteLine("s ------ Subtraction");
            Console.WriteLine("m ------ Multiplication");
            Console.WriteLine("d ------ Division");

            char answer = Convert.ToChar(Console.ReadLine());

            switch (answer)
            {
                case 'a':
                    int result = num1 + num2;
                    Console.WriteLine(result);
                    break;

                case 's':
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;

                case 'm':
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;

                case 'd':
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
            }


        }
    }
}
