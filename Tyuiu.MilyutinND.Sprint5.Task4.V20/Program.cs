using Tyuiu.MilyutinND.Sprint5.Task4.V20.Lib;

DataService ds = new DataService();
string path = $@"C:\DataSprint5\InPutDataFileTask4V20.txt";
Console.WriteLine("Файл: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadLine();