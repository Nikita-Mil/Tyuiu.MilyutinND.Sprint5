
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.MilyutinND.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutDataFileTask7V12.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string ws1 = "ёйцукенгшщзхъфывапролджэячсмитьбю";
            string ws2 = "ЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j = 0; j < ws1.Length; j++)
                        {
                            if (ws1[j] == line[i])
                            {
                                strLine += ws2[j];
                                break;
                            }
                            if (j == ws1.Length - 1)
                            {
                                strLine += line[i];
                            }
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

                return pathSaveFile;
            }
        }
    }
}
