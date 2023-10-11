using Lib;
using static Lib.BigInt;
using static Lib.Utils;
namespace P
{
    class P
    {
        static void Main()
        {
            string n1 = "-11111111111111111111111111";
            string n2 = "22222222222222222222222222";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = (num1*num2).ToString();
           Console.WriteLine(result);
        }
    }
}