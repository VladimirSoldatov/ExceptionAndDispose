using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            WriteLine(unchecked((byte)(b + 200))); // b = 44
            try
            {
                WriteLine(checked((byte)(b + 200)));
                //генерация исключения
            }
            catch (OverflowException oe)
            {
                WriteLine(oe.Message);
            }
        }
    }
}