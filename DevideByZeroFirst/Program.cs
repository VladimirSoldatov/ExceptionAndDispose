using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Код до исключения");//1
                throw new Exception("Test Exception"); //2
                                                       // Эта строка никогда не появится
                WriteLine("Код после исключения");
            }
            catch (Exception e)
            {
                WriteLine($"Ошибка: { e.Message }"); //3
            }
            finally
            {
                WriteLine("Кода блока finally");//4
            }
        }
    }
}