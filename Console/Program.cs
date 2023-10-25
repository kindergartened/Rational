using Lib;
using static Lib.BigInt;
using static Lib.Utils;
namespace P
{
    class P
    {
        static void Main()
        {
            string n1 = "1000";
            string n2 = "25";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = (num1/num2).ToString();
           Console.WriteLine(result);
        }
    }
}