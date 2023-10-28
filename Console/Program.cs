using Lib;
using static Lib.BigInt;
using static Lib.Utils;
namespace P
{
    class P
    {
        static void Main()
        {
            string n1 = "12358846";
            string n2 = "89748";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = (num1/num2).ToString().TrimStart('0');
           Console.WriteLine(result);
        }
    }
}