using Tyuiu.GoryaevTT.Sprint7.Task7.V23.lib;
namespace Tyuiu.GoryaevTT.Sprint7.Task7.V23
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 7");
            Console.WriteLine("Вариант 23");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу, которая вычисляет математическое выражение по исходным значениям данных,");
            Console.WriteLine("вводимых пользователем. Ответ округлите до 3 знаков после запятой.");
            Console.WriteLine("z = x - 10**sinx + 20x**2/3x**3 + cos(x**2 - y)");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"z = {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}
}