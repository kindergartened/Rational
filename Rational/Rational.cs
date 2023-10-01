using System.Diagnostics.CodeAnalysis;
using System.Numerics;
namespace Lib
{
    public class Rational
    {
        /// <summary>
        /// метод,необходимый для выполнение операции умножения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат умножения n1*n2</returns>
        public static BigInteger MultiplyBig(string n1,string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            BigInteger result = BigInteger.Multiply(num1, num2);
            return result;
        }
        /// <summary>
        /// метод,необходимый для выполнение операции сложения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string AddBig(string n1,string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1+num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции вычитания двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string MinusBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1 - num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции деления двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static BigInteger DivideBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            BigInteger result = BigInteger.Divide(num1, num2);
            return result;
        }
    }
}