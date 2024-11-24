using Tyuiu.MilyutinND.Sprint5.Task1.V21.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   *");
Console.WriteLine("* трёх знаков после запятой.                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int start = -5;
int end = 5;
Console.WriteLine("Начальная координата : " + start);
Console.WriteLine("Конечная координата : " + end);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(start, end);
Console.WriteLine("Файл :" + res);
Console.WriteLine("Создан!");
Console.ReadKey();