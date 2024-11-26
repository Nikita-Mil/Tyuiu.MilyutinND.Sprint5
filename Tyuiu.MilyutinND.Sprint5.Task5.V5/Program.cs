using Tyuiu.MilyutinND.Sprint5.Task5.V5.Lib;

DataService ds = new DataService();
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Условие                                                                     *");
Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить     *");
Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после     *");
Console.WriteLine("* запятой) и вернуть полученный результат на консоль                          *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Исходные данные:                                                            *");
Console.WriteLine("*******************************************************************************");

string path = @"C:\DataService5\InPutDataFileTask5V5.txt";
Console.WriteLine("Данные файла находятся в " + path);
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Результат:                                                                  *");
Console.WriteLine("*******************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();