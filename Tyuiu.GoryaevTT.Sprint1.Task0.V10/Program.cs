using Tyuiu.GoryaevTT.Sprint1.Task0.V10.lib;

namespace Tyuiu.GoryaevTT.Sprint1.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 0");
            Console.WriteLine("Вариант 10");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Напечатать программу, которая вычисляет выражение (3/6-4)*3");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("(3/6-4)*3");
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }

    }
}