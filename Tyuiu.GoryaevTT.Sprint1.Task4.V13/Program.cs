using Tyuiu.GoryaevTT.Sprint1.Task4.V13.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task4.V13
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 4");
            Console.WriteLine("Вариант 13");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные,");
            Console.WriteLine("вычисляет результат по формуле cos(Pi/x)/3e**(x+y) и печатает его на экране.");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"{ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}