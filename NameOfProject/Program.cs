using System;
using static System.Console;
namespace SimpleProject
{
    class ExampleNameOf
    {
        public string Name { get; set; }
        public ExampleNameOf(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExampleNameOf example = new ExampleNameOf(null);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}