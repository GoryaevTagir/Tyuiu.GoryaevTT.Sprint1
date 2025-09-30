using Tyuiu.GoryaevTT.Sprint1.Task6.V18.lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task6.V18
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт1/ выполнил Горяев Т.Т./ ПИНб-25-1";
            Console.WriteLine("Тема: Базовые навыки работы с C#");
            Console.WriteLine("Задание 6");
            Console.WriteLine("Вариант 18");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Пользователь вводит текст.");
            Console.WriteLine("Проверить, что строка является символьным представлением натурального числа.");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите строку:");
            string x = Console.ReadLine();
            Console.WriteLine("РЕЗУЛТАТ:");
            Console.WriteLine($"{ds.CheckNumber(x)}");
            Console.ReadKey();
        }
    }
}