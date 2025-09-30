using Tyuiu.GoryaevTT.Sprint1.Task5.V2.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task5.V2
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 5");
            Console.WriteLine("Вариант 2");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Дано значение температуры в градусах Фаренгейта.");
            Console.WriteLine("Определить значение этой же температуры в градусах Цельсия.");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите температуру в Фаренгейтах:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"{ds.FahrenheitToСelsius(x)}");
            Console.ReadKey();
        }
    }
}