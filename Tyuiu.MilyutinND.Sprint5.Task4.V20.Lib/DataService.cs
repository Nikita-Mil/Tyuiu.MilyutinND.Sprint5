using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MilyutinND.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            DataService ds = new();
            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');
            double x = Convert.ToDouble(str);
            double gg = ds.Calculate(x);
            return gg;
        }
        public double Calculate(double x)
        {
            double gg = Math.Pow((x * x) / (Math.Sin(x)), 3);
            return Math.Round(gg, 3);

            //double y = Math.Pow((x * x) / (Math.Sin(x)), 3);
        }
    }
}
