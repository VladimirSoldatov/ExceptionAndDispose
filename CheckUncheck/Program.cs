using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            try
            {
                checked
                {
                    b++; // генерация OverflowException
                }
                WriteLine(b);
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }
            try
            {
                unchecked
                {
                    b++; // переполнение игнорируется
                }
                WriteLine(b); //0
            }
            catch (OverflowException e)
            {
                WriteLine(e.Message);
            }
        }
    }
}