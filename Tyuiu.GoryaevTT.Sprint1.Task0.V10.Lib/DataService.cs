using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoryaevTT.Sprint1.Task0.V10.lib
{
    public class DataService : ISprint1Task0V10
    {
        public double Calculate()
        {
            double x = (3 / 6);
            return Math.Round((x - 4) * 3, 1);
        }
    }
}