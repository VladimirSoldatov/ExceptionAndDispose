﻿using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                throw; //передача исключения вверх
                       //по стеку вызовов
            }
            return result;
        }
        static void Main(string[] args)
        {
            WriteLine("Введите два числа");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse(ReadLine());
                number2 = int.Parse(ReadLine());
                result = DivisionNumbers(number1, number2);
                WriteLine($"Результат деления чисел: " +
                    $"{ result }");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}