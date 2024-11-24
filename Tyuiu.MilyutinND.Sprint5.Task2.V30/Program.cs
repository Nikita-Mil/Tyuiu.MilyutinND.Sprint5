using Tyuiu.MilyutinND.Sprint5.Task2.V30.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
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

int[,] matrx = new int[3, 3] { { 3, -1, -3 }, { -2, -5, 0 }, { -8, -7, 2 } };
int rows = matrx.GetLength(0);
int columns = matrx.GetLength(1);

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrx[i, j]} \t");
    }
    Console.WriteLine();
}

string res = ds.SaveToFileTextData(matrx);

Console.Write("Файл: " + res);
Console.WriteLine("Создан");
Console.ReadKey();