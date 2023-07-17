using System;
using static System.Console;
namespace SimpleProject
{
    class DisposeExample : IDisposable
    {
        public void Dispose()
        {
            WriteLine("Очистка ресурсов");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DisposeExample de = new DisposeExample();
            de.Dispose();
        }
    }
}