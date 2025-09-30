using Tyuiu.GoryaevTT.Sprint1.Task3.V3.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 3");
            Console.WriteLine("Вариант 3");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу вычисления объема параллелепипеда. Ответ округлите до 3 знаков после запятой.");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите длину(см) параллелепипеда:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину(см) параллелепипеда:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту(см) параллелепипеда:");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина (см) -> {x}");
            Console.WriteLine($"Ширина (см) -> {y}");
            Console.WriteLine($"Высота (см) -> {z}");
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"Объем: {ds.ParallelepipedVolume(x, y, z)} см.куб.");
            Console.ReadKey();
        }
    }
}