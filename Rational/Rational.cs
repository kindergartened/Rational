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
        public static string MultiplyBig(string n1, string n2)
        {
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
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
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
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
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
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
            BigInteger num1 = BigInteger.Parse(n1);
            BigInteger num2 = BigInteger.Parse(n2);
            BigInteger result = BigInteger.Divide(num1, num2);
            return result.ToString();
        }
    }
    public class BigInt
    {
        private List<int> digits; 
        /// <summary>
        /// преобразование числа в формате string в BigInt
        /// </summary>
        /// <param name="number">число в формате string</param>
        public BigInt(string number)
        {
            digits = new List<int>();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                digits.Add(digit);
            }
        }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="digits">список цифр</param>
        public BigInt(List<int> digits)
        {
            this.digits = digits;
        }
        /// <summary>
        /// переопределение оператора сложения для того чтобы складывать BigInt числа 
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns></returns>
        public static BigInt operator +(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new List<int>();
            int carry = 0;

            for (int i = 0; i < Math.Max(num1.digits.Count, num2.digits.Count); i++)
            {
                int digit1 = i < num1.digits.Count ? num1.digits[i] : 0;
                int digit2 = i < num2.digits.Count ? num2.digits[i] : 0;

                int sum = digit1 + digit2 + carry;
                int remainder = sum % 10;
                carry = sum / 10;

                resultDigits.Add(remainder);
            }

            if (carry > 0)
            {
                resultDigits.Add(carry);
            }

            return new BigInt(resultDigits);
        }
        /// <summary>
        /// переопределение оператора вычитания для того чтобы вычитать BigInt числа 
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns></returns>
        public static BigInt operator -(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new List<int>();
            int borrow = 0;

            for (int i = 0; i < Math.Max(num1.digits.Count, num2.digits.Count); i++)
            {
                int digit1 = i < num1.digits.Count ? num1.digits[i] : 0;
                int digit2 = i < num2.digits.Count ? num2.digits[i] : 0;

                int difference = digit1 - digit2 - borrow;

                if (difference < 0)
                {
                    difference += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                resultDigits.Add(difference);
            }

            //изменить в случае если 2ое число больше(мб операнд сравнения добавить)

            return new BigInt(resultDigits);
        }
        /// <summary>
        /// операнд сравнения "больше"
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>true если num1>num2,иначе false</returns>
        public static bool operator >(BigInt num1, BigInt num2)
        {
            return true;
        }
        /// <summary>
        /// операнд сравнения "меньше"
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>true если num1<num2,иначе false</returns>
        public static bool operator <(BigInt num1, BigInt num2)
        {
            return true;
        }
        /// <summary>
        /// переопределения операнда умножения для того чтобы умножать числа в формате BigInt
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">второе число</param>
        /// <returns>Результат умножения n1*n2</returns>
        public static BigInt operator *(BigInt num1, BigInt num2)
        {
            BigInt result = new BigInt("0");
            for(int i = 0; i < num1.digits.Count; i++)
            {
                result += num2;
            }
            return result;
        }
        /// <summary>
        /// переопределение метода ToString() для вывода числа в формате string
        /// </summary>
        /// <returns>число в формате string</returns>
        public override string ToString()
        {
            string number = "";

            for (int i = digits.Count - 1; i >= 0; i--)
            {
                number += digits[i];
            }

            return number;
        }
        //деление надо добавить
       /*public static BigInt operator /(BigInt num1, BigInt num2)
        {
            
        }*/
    }
}