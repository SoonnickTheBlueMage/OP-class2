namespace Task1
{
    public class Task1
    {
/*
 * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
 * где NN — длина заданной строки. Например, если задана строка "hello",
 * то результатом должна быть строка "Длина: 5".
 */

// так как в исходнике задания функция типа int, я сделал возврат длины строки и вывод того, что просят 
        internal static int StringLength(string s)
        {
            Console.WriteLine($"Длина: {s.Length}");
            return s.Length;
        }

/*
 * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
 * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
 */
        internal static Tuple<int?, int?> FirstLastCodes(string s)
        {
            return new Tuple<int?, int?>(Code(First(s)), Code(Last(s)));
        }
        
        private static char? First(string s) => s.First(); 
        private static char? Last(string s) => s.Last();
        private static int? Code(char? c) => (int?) c;
       

/*
 * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться циклом for.
 */
        internal static int CountDigits(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i])) n++;
            }

            return n;
        }

/*
 * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться методом Count:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
 * и функцией Char.IsDigit:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
 */
        internal static int CountDigits2(string s)
        {
            return s.Count(c => Char.IsDigit(c) == true);
        }
        
/*
 * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
 * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
 * данного выражения (целое число).
 */
        internal static int CalcDigits(string expr)
        {
            int s = 0;
            int sign = 1;
            foreach (var i in expr)
            {
                if (i == '-')
                {
                    sign = -1;
                }
                else if (i == '+')
                {
                    sign = 1;
                }
                else
                {
                    s += sign * Int32.Parse(i.ToString());
                }
            }

            return s;
        }

/*
 * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
 */
        internal static string ReplaceWithString(string s, string s1, string s2)
        {
            int ind = s.IndexOf(s1);
            return s.Remove(ind, s1.Length).Insert(ind, s2);
        }
        

        public static void Main(string[] args)
        {
            Console.WriteLine(StringLength("test1"));
            Console.WriteLine(FirstLastCodes("task2"));
            Console.WriteLine(CountDigits("th1s strin9 h0s 4 digits"));
            Console.WriteLine(CountDigits2("th1s 0ne(1) h4s 5"));
            Console.WriteLine(CalcDigits("1+2+3-4"));
            Console.WriteLine(ReplaceWithString("hello Alex", "Alex", "World"));
        }
    }
}