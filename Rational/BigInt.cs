namespace Lib
{
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
        /// проверка на отрицательное число
        /// </summary>
        /// <param name="number">число в формате string</param>
        /// <returns></returns>
        public bool IsNegative(string number)
        {
            if (number[0]=='-')
                return false;
            return true;
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
        /// Переопределение оператора сдвига влево для сдвига цифр BigInt числа на указанное количество разрядов влево.
        /// </summary>
        /// <param name="num">Исходное BigInt число.</param>
        /// <param name="shift">Количество разрядов для сдвига.</param>
        /// <returns>BigInt число после сдвига влево.</returns>
        public static BigInt operator <<(BigInt num, int shift)
        {
            if (shift < 0)
            {
                throw new ArgumentException("Shift value must be non-negative.");
            }

            List<int> shiftedDigits = new List<int>(num.digits);
            shiftedDigits.InsertRange(0, new int[shift]); // Вставляем нули в начало списка

            return new BigInt(shiftedDigits);
        }

        /// <summary>
        /// Переопределение оператора сдвига вправо для сдвига цифр BigInt числа на указанное количество разрядов вправо.
        /// </summary>
        /// <param name="num">Исходное BigInt число.</param>
        /// <param name="shift">Количество разрядов для сдвига.</param>
        /// <returns>BigInt число после сдвига вправо.</returns>
        public static BigInt operator >>(BigInt num, int shift)
        {
            if (shift < 0)
            {
                throw new ArgumentException("Shift value must be non-negative.");
            }

            if (shift >= num.digits.Count)
            {
                return new BigInt("0"); // Если сдвиг больше или равен количеству цифр, результат - ноль.
            }

            List<int> shiftedDigits = new List<int>(num.digits);
            shiftedDigits.RemoveRange(0, shift); // Удаляем первые shift цифр

            return new BigInt(shiftedDigits);
        }

        /// <summary>
        /// Оператор деления BigInt числа на другое BigInt число.
        /// </summary>
        /// <param name="num1">Делимое BigInt число.</param>
        /// <param name="num2">Делитель BigInt число.</param>
        /// <returns>Частное от деления двух BigInt чисел.</returns>
        public static BigInt operator /(BigInt num1, BigInt num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            BigInt quotient = new BigInt("0");
            BigInt remainder = new BigInt(num1.ToString());

            while (remainder >= num2)
            {
                BigInt temp = new BigInt(num2.ToString());
                int count = 0;

                while (remainder >= (temp << 1))
                {
                    temp <<= 1;
                    count++;
                }

                remainder -= temp;
                quotient += new BigInt("1") << count;
            }

            return quotient;
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

    }
}