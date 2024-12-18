﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MilyutinND.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            FileInfo fi = new FileInfo(path);
            bool fe = fi.Exists;
            if (fe)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
                stry = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
