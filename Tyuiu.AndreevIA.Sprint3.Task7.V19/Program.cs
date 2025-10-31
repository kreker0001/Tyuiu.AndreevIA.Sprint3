using Tyuiu.AndreevIA.Sprint3.Task7.V19.Lib;
namespace Tyuiu.AndreevIA.Sprint3.Task1.V14;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил Андреев И. А. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений                    *");
        Console.WriteLine("* функции на заданном диапазоне с шагом 1:                                *");
        Console.WriteLine("*    F(x) = (5x + 2.5) / (sin(x) - 2) + 2                                 *");
        Console.WriteLine("* Диапазон: [-5; 5], шаг: 1.                                              *");
        Console.WriteLine("* Выполнить проверку деления на ноль:                                     *");
        Console.WriteLine("*   если sin(x) - 2 == 0, вернуть 0.                                      *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
        Console.WriteLine("* Все полученные значения занести в массив и вывести таблицу.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Формула: F(x) = (5x + 2.5) / (sin(x) - 2) + 2                           *");
        Console.WriteLine("* Начало диапазона: -5                                                    *");
        Console.WriteLine("* Конец диапазона: 5                                                      *");
        Console.WriteLine("* Шаг табулирования:1                                                     *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double[] res = ds.GetMassFunction(-5, 5);
        foreach (double x in res) Console.WriteLine(x);

        Console.ReadKey();
    }
}