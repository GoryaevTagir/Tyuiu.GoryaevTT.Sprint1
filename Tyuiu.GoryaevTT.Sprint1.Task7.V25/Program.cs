using Tyuiu.GoryaevTT.Sprint1.Task7.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint1.Task7.V25
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Class1 ds = new Class1();
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
        }
    }
}