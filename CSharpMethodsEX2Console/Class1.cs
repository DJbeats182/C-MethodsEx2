using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodsEX2Console
{
    internal class Methods
    {
        public static int Sum(int num1, int num2) // Adds two numbers together
        {
            int answer = num1 + num2;
            return answer;
        }

        public static void Add()
        {
            Console.WriteLine("Enter in a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in a second number:");
            int num2 = int.Parse(Console.ReadLine());
            var answer = num1 + num2;   
            Console.WriteLine($"{num1} + {num2} = {answer}");
        }

        public static int Multiply(int num1, int num2) // Multiplies two numbers together
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2) // Subtracts two numbers 
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2) // Divides two numbers 
        {
            return num1/ num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2; 
        }

        public static int SumVal(params int[] values)
        {
            int sum = 0;
            foreach (int val in values)
            {
                sum += val;
            }
            return sum;
        }

        public static int SubVals(params int[] list)
        {
            var startingPoint = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                startingPoint -= list[i];
            }
            return startingPoint;
        }
    }
}
