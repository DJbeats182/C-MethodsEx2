namespace CSharpMethodsEX2Console
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            int answer = num1 + num2; 
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            var pizzaPrices = Sum(2, 4);
          
            var pizzaToppings = Multiply(2, 10);

            Console.WriteLine(pizzaPrices);
            Console.WriteLine(pizzaToppings);
        }
    }
}