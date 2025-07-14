namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int moneyOne, int moneyTwo)
        {
            return moneyOne + moneyTwo;
        }

        public static decimal Add(decimal moneyOne, decimal moneyTwo)
        {
            return moneyOne + moneyTwo;
        }

        public static string Add(decimal moneyOne, decimal moneyTwo, bool isMoney)
        {
            var sum = moneyOne + moneyTwo;
            if (isMoney == true && sum > 1)
            {
                return $"${sum} Dollars";
            }
            if (isMoney == true && sum == 1)
            {
                return $"${sum} Dollar";
            }
            if (isMoney == true && sum < 1)
            {
                return $"${sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var a = 35;
            var b = 15;
            var answer = Add(a, b);

            var c = 25.0m;
            var d = 5.0m;
            var dAnswer = Add(d, c);

            var e = 1.0m;
            var f = 0;
            
            var tAnswer = Add(a, b, true);
            var oneAnswer = Add(e, f, true);
            var fAnswer = Add(a, c, false);
            
            Console.WriteLine($"int add: {answer}, decimal add: {dAnswer}");
            Console.WriteLine(tAnswer);
            Console.WriteLine(oneAnswer);
            Console.WriteLine(fAnswer);
        }
    }
}
