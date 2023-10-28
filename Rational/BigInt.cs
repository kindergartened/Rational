using Microsoft.VisualBasic.FileIO;
using System.Numerics;
using System.Text;

namespace Lib
{
    public class BigInt
    {
        private List<int> digits;
        private bool isNegative = false;

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
        public bool IsNegative => isNegative;

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
            List<int> resultDigits = new();
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
            List<int> resultDigits = new();
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
            return num1 >= num2 && num1 != num2;
        }

        /// <summary>
        /// Переопределение оператора "больше или равно" для сравнения двух BigInt чисел.
        /// </summary>
        /// <param name="num1">Первое BigInt число.</param>
        /// <param name="num2">Второе BigInt число.</param>
        /// <returns>True, если первое число больше или равно второму; в противном случае - False.</returns>
        public static bool operator >=(BigInt num1, BigInt num2)
        {
            return !(num1 < num2);
        }

        /// <summary>
        /// операнд сравнения "меньше"
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>true если num1<num2,иначе false</returns>
        public static bool operator <(BigInt num1, BigInt num2)
        {
            return num1 <= num2 && num1 != num2;
        }

        /// <summary>
        /// Переопределение оператора "меньше или равно" для сравнения двух BigInt чисел.
        /// </summary>
        /// <param name="num1">Первое BigInt число.</param>
        /// <param name="num2">Второе BigInt число.</param>
        /// <returns>True, если первое число меньше или равно второму; в противном случае - False.</returns>
        public static bool operator <=(BigInt num1, BigInt num2)
        {
            if (num1.digits.Count < num2.digits.Count)
            {
                return true;
            }
            else if (num1.digits.Count > num2.digits.Count)
            {
                return false;
            }
            else
            {
                for (int i = num1.digits.Count - 1; i >= 0; i--)
                {
                    if (num1.digits[i] < num2.digits[i])
                    {
                        return true;
                    }
                    else if (num1.digits[i] > num2.digits[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// переопределения операнда умножения для того чтобы умножать числа в формате BigInt
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">второе число</param>
        /// <returns>Результат умножения n1*n2</returns>
        public static BigInt operator *(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new List<int>(new int[num1.digits.Count + num2.digits.Count]);

            for (int i = 0; i < num1.digits.Count; i++)
            {
                int carry = 0;

                for (int j = 0; j < num2.digits.Count || carry > 0; j++)
                {
                    int product = resultDigits[i + j] + num1.digits[i] * (j < num2.digits.Count ? num2.digits[j] : 0) + carry;
                    resultDigits[i + j] = product % 10;
                    carry = product / 10;
                }
            }

            // Удаляем ведущие нули из результата
            while (resultDigits.Count > 1 && resultDigits[resultDigits.Count - 1] == 0)
            {
                resultDigits.RemoveAt(resultDigits.Count - 1);
            }

            return new BigInt(resultDigits);
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

        /// <summary>
        /// Переопределение оператора инкремента для увеличения значения BigInt на 1.
        /// </summary>
        /// <param name="num">Исходное BigInt число.</param>
        /// <returns>Увеличенное на 1 BigInt число.</returns>
        public static BigInt operator ++(BigInt num) => num + new BigInt("1");

        /// <summary>
        /// Оператор деления BigInt числа на другое BigInt число.
        /// </summary>
        /// <param name="num1">Делимое BigInt число.</param>
        /// <param name="num2">Делитель BigInt число.</param>
        /// <returns>Частное от деления двух BigInt чисел.</returns>
        public static BigInt operator /(BigInt dividend, BigInt divisor)
        {
            List<int> dividendDigits = new();
            dividendDigits.AddRange(dividend.digits);
            dividendDigits.Reverse();
            List<int> divisorDigits = new();
            divisorDigits.AddRange(divisor.digits);
            divisorDigits.Reverse();

            List<int> answer = new List<int>();

            int tempDividend = 0;
            int currentIndex = 0;

            // Пока не пройдем по всем цифрам в делимом числе
            while (currentIndex < dividendDigits.Count)
            {
                tempDividend = tempDividend * 10 + dividendDigits[currentIndex];
                currentIndex++;

                int quotient = 0;

                // Выполняем деление, пока tempDividend не станет меньше divisor
                while (tempDividend >= divisor)
                {
                    tempDividend -= (int)divisor;
                    quotient++;
                }

                answer.Add(quotient);
            }
            BigInt res = new BigInt(answer);
            res.digits.Reverse();

            return res;
        }

        /// <summary>
        /// Переопределение оператора равенства для сравнения двух BigInt чисел.
        /// </summary>
        /// <param name="num1">Первое BigInt число.</param>
        /// <param name="num2">Второе BigInt число.</param>
        /// <returns>True, если числа равны; в противном случае - False.</returns>
        public static bool operator ==(BigInt num1, BigInt num2)
        {
            if (num1 is null || num2 is null)
            {
                return ReferenceEquals(num1, num2);
            }

            if (num1.digits.Count != num2.digits.Count)
            {
                return false;
            }

            for (int i = 0; i < num1.digits.Count; i++)
            {
                if (num1.digits[i] != num2.digits[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Переопределение оператора неравенства для сравнения двух BigInt чисел.
        /// </summary>
        /// <param name="num1">Первое BigInt число.</param>
        /// <param name="num2">Второе BigInt число.</param>
        /// <returns>True, если числа не равны; в противном случае - False.</returns>
        public static bool operator !=(BigInt num1, BigInt num2)
        {
            return !(num1 == num2);
        }

        /// <summary>
        /// Переопределение оператора равенства для сравнения BigInt с целым числом.
        /// </summary>
        /// <param name="num1">BigInt число.</param>
        /// <param name="num2">Целое число.</param>
        /// <returns>True, если BigInt число равно целому числу; в противном случае - False.</returns>
        public static bool operator ==(BigInt num1, int num2)
        {
            return num1 == new BigInt(num2.ToString());
        }

        /// <summary>
        /// Переопределение оператора неравенства для сравнения BigInt с целым числом.
        /// </summary>
        /// <param name="num1">BigInt число.</param>
        /// <param name="num2">Целое число.</param>
        /// <returns>True, если BigInt число не равно целому числу; в противном случае - False.</returns>
        public static bool operator !=(BigInt num1, int num2)
        {
            return num1 != new BigInt(num2.ToString());
        }

        /// <summary>
        /// Переопределение оператора равенства для сравнения целого числа с BigInt.
        /// </summary>
        /// <param name="num1">Целое число.</param>
        /// <param name="num2">BigInt число.</param>
        /// <returns>True, если целое число равно BigInt числу; в противном случае - False.</returns>
        public static bool operator ==(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) == num2;
        }

        /// <summary>
        /// Переопределение оператора неравенства для сравнения целого числа с BigInt.
        /// </summary>
        /// <param name="num1">Целое число.</param>
        /// <param name="num2">BigInt число.</param>
        /// <returns>True, если целое число не равно BigInt числу; в противном случае - False.</returns>
        public static bool operator !=(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) != num2;
        }

        public static BigInt operator -(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) - num2;
        }

        public static BigInt operator -(BigInt num2, int num1)
        {
            return new BigInt(num2.ToString()) - num1;
        }

        public static bool operator >=(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) >= num2;
        }

        public static bool operator <=(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) <= num2;
        }

        public static explicit operator int(BigInt v)
        {
            return int.Parse(v.ToString());
        }
    }
}