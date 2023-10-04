using Lib;
using static Lib.BigInt;
using static Lib.Rational;
namespace P
{
    class P
    {
        static void Main()
        {
            string n1 = "1111111";
            string n2 = "2222222";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = MultiplyBig(n2, n1);
            Console.WriteLine(result);


        }
    }
}