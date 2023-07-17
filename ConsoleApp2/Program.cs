
using System;
using static System.Console;

namespace SimpleProject
{
    [Serializable]
public class MyException : Exception
{
    public DateTime TimeException { get; private set; }
    public MyException() : this("Мое исключение")
    { TimeException = DateTime.Now; }
    public MyException(string message) : base(message) { }
    public MyException(string message, Exception inner)
    : base(message, inner) { }
    protected MyException(System.Runtime.Serialization.
    SerializationInfo info,
    System.Runtime.Serialization.
    StreamingContext context)
    : base(info, context) { }
}



    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите два числа");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse(ReadLine());
                number2 = int.Parse(ReadLine());
                result = number1 / number2;
                WriteLine($"Результат деления чисел { result}");
            }
            catch (DivideByZeroException de)
            {
                WriteLine(de.Message);
            }
            finally
            {
                WriteLine("Очистка ресурсов");
            }
        }
    }
}