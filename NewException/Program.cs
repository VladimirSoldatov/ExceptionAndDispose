using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void f2()
        {
            throw new Exception("MyException");
            //генерация исключения
        }
        static void f1()
        {
            f2();
        }
        static void f()
        {
            try
            {
                f1();
            }
            catch (Exception e)
            //перехват исключения
            {
                WriteLine(e.Message);
                //вывод стека трассировки
                WriteLine("Stack trace:\n { 0} ", e.StackTrace);
            }
        }
        static void Main(string[] args)
        {
            f();
        }
    }
}