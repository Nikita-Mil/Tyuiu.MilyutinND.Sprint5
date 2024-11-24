using Tyuiu.MilyutinND.Sprint5.Task0.V16.Lib;

Console.Title = "Спринт #5 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка файлов                                                  *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


DataService ds = new DataService();
int x = 3;

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");


Console.ReadLine();