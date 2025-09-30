using Tyuiu.GoryaevTT.Sprint1.Task1.V10.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task1.V10
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Вариант 10");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Напечатать программу, которая вычисляет результат по формуле (x+y)/(1+x) и печатает его на экране");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }

    }
}