namespace CSharpMethodsEX2Console
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            //--------------------------Methods-Exercise-2---------------------------

            int sum = Methods.Sum(1, 1);
            Console.WriteLine($"The sum of num1 and num2 is {sum}");
            int difference = Methods.Subtract(2,2);
            Console.WriteLine($"The difference of num1 and num2 is {difference}");
            int product = Methods.Multiply(2,2);
            Console.WriteLine($"The product of num1 and num2 is {product}");
            int quotient = Methods.Divide(10,2);
            Console.WriteLine($"The quotient of num1 and num2 is {quotient}");
            Methods.Add();
            

            //--------------------------Challenge-Mode-------------------------------
                     
            

            Console.WriteLine(Methods.SumVal(1, 1, 1, 3)); // takes each number in the variabled list and adds them together
            Console.WriteLine(Methods.SubVals(10,2,1,1));  // takes each number in the variabled list and subtracts them together
        }
    }
}
