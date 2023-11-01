using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Lib
{
    public class BigInt
    {
        private List<int> digits;
        private bool isNegative = false;

        /// <summary>
        /// Конструктор, принимающий string, определяет отрицательность числа и добавляет цифры в digits
        /// </summary>
        /// <param name="number">число с типом string</param>
        public BigInt(string number)
        {
            isNegative = number[0] == '-';
            if (isNegative) number = number.Substring(1);
            digits = new List<int>();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                digits.Add(digit);
            }
        }

        /// <summary>
        /// Конструктор, принимающий list целых чисех
        /// </summary>
        /// <param name="digits">список целых цифр</param>
        public BigInt(List<int> digits)
        {
            this.digits = digits;
        }

        /// <summary>
        /// Свойство отрицательности числа (bool)
        /// </summary>
        public bool IsNegative 
        {
            get 
            {
                return isNegative;
            }
            set
            {
                isNegative = value;
            }
        }

        /// <summary>
        /// Определение оператора сложения BigInt чисел
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>Результат сложения</returns>
        public static BigInt operator +(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new();
            int carry = 0;

            BigInt? negativeCheck = Utils.AdditionNegative(num1, num2);
            if (negativeCheck != null)
            {
                return negativeCheck;
            }

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
            Utils.DeleteZeros(ref resultDigits);

            return new BigInt(resultDigits);
        }

        /// <summary>
        /// Определение оператора вычитания BigInt чисел
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>Вычитание чисел</returns>
        public static BigInt operator -(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new();
            int borrow = 0;

            BigInt? negativeCheck = Utils.SubstractionNegative(num1, num2);
            if (negativeCheck != null)
            {
                return negativeCheck;
            }

            for (int i = 0; i < Math.Max(num1.digits.Count, num2.digits.Count); i++)
            {
                int digit1 = i < num1.digits.Count ? num1.digits[i] : 0;
                int digit2 = i < num2.digits.Count ? num2.digits[i] : 0;

                int difference = (digit1) - (digit2) - borrow;

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
            Utils.DeleteZeros(ref resultDigits);

            return new BigInt(resultDigits);
        }

        /// <summary>
        /// Определение оператора умножения BigInt чисел
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">второе число</param>
        /// <returns>Результат умножения num1 на num2</returns>
        public static BigInt operator *(BigInt num1, BigInt num2)
        {
            List<int> resultDigits = new List<int>(new int[num1.digits.Count + num2.digits.Count]);

            BigInt? negativeCheck = Utils.MultiplyNegative(ref num1, ref num2);
            if (negativeCheck != null)
            {
                return negativeCheck;
            }

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
        /// Определение оператора возведения в степень BigInt числа 
        /// </summary>
        /// <param name="num1">Возводимое число</param>
        /// <param name="s">Степень</param>
        /// <returns>Возведенное число num1 в степень s</returns>
        public static BigInt operator ^(BigInt num1, BigInt s)
        {
            BigInt res = num1;
            BigInt zero = new("0");
            BigInt two = new("2");
            BigInt one = new("1");

            if (s == zero) return one;
            if (s == one) return num1;
            if (s.isNegative) return zero; // потому что (1/num1)^s = 0, т.к. BigInt - целочисленный класс

            BigInt? negativeCheck = Utils.PowNegative(ref num1, ref s);
            if (negativeCheck != null)
            {
                return negativeCheck;
            }

            for (BigInt k = one; k < s / two; k++)
            {
                res *= num1;
            }
            

            if (s % two != new BigInt("0"))
                return res * res * num1;
            else
                return res * res;
        }

        /// <summary>
        /// Переопределение метода ToString() для вывода числа в формате string
        /// </summary>
        /// <returns>число в формате string</returns>
        public override string ToString()
        {
            string number = "";

            for (int i = digits.Count - 1; i >= 0; i--)
            {
                number += digits[i];
            }

            return isNegative ? $"-{number}" : number;
        }

        /// <summary>
        /// Определение оператора инкремента для увеличения значения BigInt на 1.
        /// </summary>
        /// <param name="num">Исходное BigInt число.</param>
        /// <returns>Увеличенное на 1 BigInt число.</returns>
        public static BigInt operator ++(BigInt num) => num + new BigInt("1");

        /// <summary>
        /// Оператор деления BigInt числа на другое BigInt число. Алгоритм - деление в столбик,
        /// поочередно проходящее по каждой цифре. Сложность примерно O(n * log(n))
        /// </summary>
        /// <param name="num1">Делимое BigInt число.</param>
        /// <param name="num2">Делитель BigInt число.</param>
        /// <returns>Частное от деления двух BigInt чисел.</returns>
        public static BigInt operator /(BigInt dividend, BigInt divisor)
        {
            List<int> dividendDigits = new();
            dividendDigits.AddRange(dividend.digits);

            List<int> answer = new();

            BigInt tempDividend = new("0");
            int currentIndex = dividendDigits.Count - 1;
            BigInt IO = new("10");

            BigInt? negativeCheck = Utils.DivisionNegative(ref dividend, ref divisor);
            if (negativeCheck != null)
            {
                return negativeCheck;
            }

            // Пока не пройдем по всем цифрам в делимом числе
            while (currentIndex >= 0)
            {
                tempDividend = tempDividend*IO+dividendDigits[currentIndex];
                currentIndex--;

                int quotient = 0;
                
                // Выполняем деление, пока tempDividend не станет меньше divisor
                while (tempDividend >= divisor)
                {
                    tempDividend -= divisor;
                    quotient++;
                }

                answer.Add(quotient);
            }
            BigInt res = new(answer);
            res.digits.Reverse();

            Utils.DeleteZeros(ref res.digits);

            return res;
        }

        /// <summary>
        /// Определение оператора остатка, вычисляющий остаток от деления BigInt чисел
        /// </summary>
        /// <param name="num1">1 число</param>
        /// <param name="num2">2 число</param>
        /// <returns>Остаток от деления num1 на num2</returns>
        public static BigInt operator %(BigInt num1, BigInt num2)
        {
            BigInt res = num1 - ((num1 / num2) * num2);
            Utils.DeleteZeros(ref res.digits);
            return res;
        }

        /// <summary>
        /// Определение оператора сравнения "больше"
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        /// <returns>true если num1>num2,иначе false</returns>
        public static bool operator >(BigInt num1, BigInt num2)
        {
            return num1 >= num2 && num1 != num2;
        }

        /// <summary>
        /// Определение оператора "больше или равно" для сравнения двух BigInt чисел.
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
        /// Определение оператора "меньше или равно" для сравнения двух BigInt чисел.
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
        /// Определение оператора равенства для сравнения двух BigInt чисел. 
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
        /// Определение оператора неравенства для сравнения двух BigInt чисел.
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
            return num2 - new BigInt(num1.ToString());
        }

        public static bool operator >=(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) >= num2;
        }

        public static bool operator <=(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) <= num2;
        }
        public static bool operator >=(long num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) >= num2;
        }

        public static bool operator <=(long num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) <= num2;
        }
        public static BigInt operator +(int num1, BigInt num2)
        {
            return new BigInt(num1.ToString()) + num2;
        }

        public static BigInt operator +(BigInt num2, int num1)
        {
            return num2 + new BigInt(num1.ToString());
        }
    }
}