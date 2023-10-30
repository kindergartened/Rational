using Lib;
using static Lib.BigInt;
using static Lib.Utils;
using System;
using System.Numerics;
using System.Text;
namespace P
{
    class P
    {
        static void Main()
        {
            string n1 = "123456789";
            string n2 = "123";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = (num1 / num2).ToString();
            Console.WriteLine(result);
        }
    }
}