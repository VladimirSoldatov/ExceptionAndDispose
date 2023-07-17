using System;
using static System.Console;
namespace SimpleProject
{
    class DisposeExample : IDisposable
    {
        //используется для того, чтобы выяснить,
        //вызывался ли метод Dispose()
        private bool isDisposed = false;
        private void Cleaning(bool disposing)
        //вспомогательный метод
        {
            //убедиться, что ресурсы ещё не освобождены
            if (!isDisposed) //очищать только один раз
            {
                //если true, то освобождаем все
                //управляемые ресурсы
                if (disposing)
                {
                    WriteLine("Освобождение управляемых ресурсов");
                }
                WriteLine("Освобождение неуправляемых ресурсов");
            }
            isDisposed = true;
        }
        public void Dispose()
        {
            //вызов вспомогательного метода
            //true - очистка инициирована пользователем
            //объекта
            Cleaning(true);
            //запретить сборщику мусора осуществлять
            //финализацию
            GC.SuppressFinalize(this);
            }
            ~DisposeExample()
            {
                //false указывает на то, что очистку
                //инициировал сборщик мусора
                Cleaning(false);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                DisposeExample test = new DisposeExample();
                test.Dispose();
                DisposeExample test1 = new DisposeExample();
            }
        }
    }