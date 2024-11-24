using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MilyutinND.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double y = Math.Round((2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
