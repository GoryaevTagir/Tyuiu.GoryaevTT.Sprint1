using Tyuiu.GoryaevTT.Sprint1.Task2.V15.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task2.V15
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Вариант 15");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране");
            Console.WriteLine("Формулировка задания: Известна длина стороны куба. Вычислить объём куба");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите длину стороны куба:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"Объем куба равен: {ds.CalculateCubeVolume(x)}");
            Console.ReadKey();
        }
    }
}