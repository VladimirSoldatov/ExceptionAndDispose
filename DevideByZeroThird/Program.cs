using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Write($"\nВведите число: ");
                    //чтение ввода пользователя
                    string str = ReadLine();
                    //условие выхода из цикла
                    if (string.IsNullOrEmpty(str))
                    {
                        return;
                    }
                    //преобразование строки в число
                    int number = Convert.ToInt32(str);
                    //проверка, что полученное число
                    //принадлежит области определения
                    //функции ln()
                    if (number <= 0)
                    {
                        throw new ArgumentOutOfRangeException ("число <= 0");
                    }
                    double log = Math.Log(number);
                    WriteLine($"ln({ number}) = { log}\n100 / ln({ number}) ={ 100 / (int)log}");
                }
                catch (FormatException fe)
                {
                    //происходит, если введенное
                    //пользователем значение
                    //невозможно преобразовать в целое число
                    WriteLine(fe.Message);
                }
                catch (DivideByZeroException de)
                {
                    //происходит, если Log(n) = 0 (т.е. n = 1)
                    WriteLine(de.Message);
                }
                catch (Exception e)
                {
                    //прехват всех остальных исключений
                    WriteLine($"Exception: { e.Message }");
                }
            } while (true);
        }
    }
}