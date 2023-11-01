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
        /// метод,необходимый для выполнения операции вычитания двух БОЛЬШИХ ЧИСЕЛ 
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
        /// метод,необходимый для выполнения операции деления двух БОЛЬШИХ ЧИСЕЛ
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
        /// <summary>
        /// метод,необходимый для выполнения операции нахождения остатка БОЛЬШИХ ЧИСЕЛ
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string TestOstBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            return (num1 % num2).ToString();
        }
        /// <summary>
        /// метод,необходимый для выполнения операции возведения в степень БОЛЬШИХ ЧИСЕЛ
        /// </summary>
        /// <param name="n1">BigInteger в формате string</param>
        /// <param name="n2">BigInteger в формате string</param>
        /// <returns></returns>
        public static string TestPowBig(string n1, string n2)
        {
            BigInteger num1 = BigInteger.Parse(n1);
            return BigInteger.Pow(num1, int.Parse(n2)).ToString();
        }

        public static BigInt? AdditionNegative(BigInt num1, BigInt num2)
        {
            if (num1.IsNegative && num2.IsNegative)
            {
                num1.IsNegative = false;
                num2.IsNegative = false;
                BigInt result = num1 + num2;
                result.IsNegative = true;
                return result;
            }
            if (num1.IsNegative && !num2.IsNegative)
            {
                num1.IsNegative = false;
                num2.IsNegative = false;
                BigInt result = num2 - num1;
                return result;
            }
            if (!num1.IsNegative && num2.IsNegative)
            {
                num2.IsNegative = false;
                BigInt result = num1 - num2;
                return result;
            }
            return null;
        }

        public static BigInt? SubstractionNegative(BigInt num1, BigInt num2)
        {
            if (num1.IsNegative && num2.IsNegative)
            {
                num1.IsNegative = false;
                num2.IsNegative = false;
                if (num2 > num1)
                {
                    BigInt result = num2 - num1;
                    return result;
                }
                else
                {
                    BigInt result = num1 - num2;
                    result.IsNegative = true;
                    return result;
                }
            }
            if (!num1.IsNegative && !num2.IsNegative && (num2 > num1))
            {
                BigInt result = num2 - num1;
                result.IsNegative = true;
                return result;
            }
            if (num1.IsNegative && !num2.IsNegative)
            {
                num1.IsNegative = false;
                BigInt result = num1 + num2;
                result.IsNegative = true;
                return result;
            }
            if (!num1.IsNegative && num2.IsNegative)
            {
                num2.IsNegative = false;
                BigInt result = num1 + num2;
                return result;
            }
            return null;
        }

        public static BigInt? MultiplyNegative(ref BigInt num1, ref BigInt num2)
        {
            if (!(num1.IsNegative == num2.IsNegative))
            {
                num1.IsNegative = false;
                num2.IsNegative = false;
                BigInt result = num1 * num2;
                result.IsNegative = true;
                return result;
            }
            num1.IsNegative = false;
            num2.IsNegative = false;
            return null;
        }

        public static BigInt? PowNegative(ref BigInt num1, ref BigInt s)
        {
            BigInt two = new BigInt("2");
            if (num1.IsNegative && (s % two != 0))
            {
                num1.IsNegative = false;
                BigInt result = num1 ^ s;
                result.IsNegative = true;
                return result;
            }
            else
            {
                num1.IsNegative = false;
            }
            return null;
        }

        public static BigInt? DivisionNegative(ref BigInt dividend, ref BigInt divisor)
        {
            if (!(dividend.IsNegative == divisor.IsNegative))
            {
                dividend.IsNegative = false;
                divisor.IsNegative = false;
                BigInt result = dividend / divisor;
                result.IsNegative = true;
                return result;
            }
            dividend.IsNegative = false;
            divisor.IsNegative = false;
            return null;
        }

        public static void DeleteZeros(ref List<int> list)
        {
            while (list[^1] == 0 && list.Count > 1)
                list.RemoveAt(list.Count - 1);
        }
    }
}