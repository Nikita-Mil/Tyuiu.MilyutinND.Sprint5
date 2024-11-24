using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MilyutinND.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            y = Math.Round(y, 2);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
