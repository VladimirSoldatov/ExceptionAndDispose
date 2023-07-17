using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите два числа");
            int number1, number2, result = 0;
            string str = null;
            try
            {
                number1 = int.Parse(ReadLine());
                number2 = int.Parse(ReadLine());
                result = number1 / number2;
                str = "Проверка";
                WriteLine("Результат деления чисел: " +result);
            }
            catch (DivideByZeroException de)
            {
                WriteLine(de.Message);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

        }
    }
}
