using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GoryaevTT.Sprint1.Task6.V18.lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (int.TryParse(value, out int result) && int.Parse(value) > 0)
            {
                Console.WriteLine("Строку можно представить натуральным числом");
                return true;
            }
            else
            {
                Console.WriteLine("Строку нельзя представить натуральным числом");
                return false;
            }
        }
    }
}