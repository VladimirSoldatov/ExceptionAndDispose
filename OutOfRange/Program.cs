using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int n = 0;
            try // внешний блок try
            {
                for (int i = -3; i <= 3; i++)
                {
                    //при делении на 0 не происходит выход
                    //из цикла: исключение перехватывается и
                    //обрабатывается внутренним блоком try
                    try //внутренний блок try
                    {
                        a[n] = 100 / i;
                        WriteLine(a[n]);
                        n++;
                    }
                    catch (DivideByZeroException e)
                    {
                        WriteLine("Внутренний catch");
                        WriteLine(e.Message);
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                WriteLine("Внешний catch");
                WriteLine(e.Message);
            }
        }
    }
}