
using Tyuiu.AndreevIA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task1.V14;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил Андреев И. А. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла While.                                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл While, которая вычисляет сумму ряда   *");
        Console.WriteLine("* по формуле, при a = 0,75                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите а: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите предел: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите k: ");
        int stop = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumSeries(a, start, stop));
        Console.ReadKey();
    }
}