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
            string n1 = "2";
            string n2 = "2";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            string result = (num1 % num2).ToString();
            if (num1%num2!=new BigInt("0"))
                Console.WriteLine("Aga");
            else
                Console.WriteLine("Pizda");
            Console.WriteLine(result);
        }
    }
}