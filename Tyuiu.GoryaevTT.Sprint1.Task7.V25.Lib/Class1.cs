using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GoryaevTT.Sprint7.Task7.V23.lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            x *= Math.PI;
            y *= Math.PI;
            if (x != 0)
            {
                return Math.Round(x - Math.Pow(10, Math.Sin(x)) + 20 * Math.Pow(x, 2) / (3 * Math.Pow(x, 3)) + Math.Cos(Math.Pow(x, 2) - y), 3);
            }
            else
            {
                Console.WriteLine("Число x не должно быть 0.");
                return 0;
            }
        }
    }
}