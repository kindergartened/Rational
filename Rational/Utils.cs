using System.Numerics;
using System.Text;
namespace Lib
{
    public class Utils
    {
        /// <summary>
        /// метод,необходимый для выполнение операции умножения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат умножения n1*n2</returns>
        public static string MultiplyBig(string n1, string n2)
        {
            BigInt num1 = new(n1);
            BigInt num2 = new(n2);
            return (num1 * num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции сложения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат сложения n1+n2</returns>
        public static string AddBig(string n1, string n2)
        {
            BigInt num1 = new(n1);
            BigInt num2 = new(n2);
            return (num1 + num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции вычитания двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат вычитания n1-n2</returns>
        public static string MinusBig(string n1, string n2)
        {
            BigInt num1 = new(n1);
            BigInt num2 = new(n2);
            return (num1 - num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции деления двух БОЛЬШИХ ЧИСЕЛ (ПОМЕНЯТЬ)
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string DivideBig(string n1, string n2)
        {
            BigInt num1 = new(n1);
            BigInt num2 = new(n2);
            return (num1 / num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции умножения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат умножения n1*n2</returns>
        public static string TestMultiplyBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            Console.WriteLine(num1);
            return (num1 * num2).ToString();
            
        }
        /// <summary>
        /// метод,необходимый для выполнение операции сложения двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат сложения n1+n2</returns>
        public static string TestAddBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1 + num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции вычитания двух БОЛЬШИХ ЧИСЕЛ 
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns>результат вычитания n1-n2</returns>
        public static string TestMinusBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1 - num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнение операции деления двух БОЛЬШИХ ЧИСЕЛ (ПОМЕНЯТЬ)
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string TestDivideBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1 / num2).ToString();
        }
    }
}