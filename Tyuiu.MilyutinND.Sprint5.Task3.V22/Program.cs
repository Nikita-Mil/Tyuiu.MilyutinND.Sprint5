using Tyuiu.MilyutinND.Sprint5.Task3.V22.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.               *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* y (x) = (1 - x, 2) / (-3 * x)                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int x = 3;

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();