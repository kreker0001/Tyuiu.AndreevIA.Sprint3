using Tyuiu.AndreevIA.Sprint3.Task5.V9.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Андреев И. А. | РППб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("************************** УСЛОВИЕ: ***************************************");
            Console.WriteLine("* Вычислить:                                                               ");
            Console.WriteLine("*   y = sum(i=1..3) sum(k=1..14) 1/sin(k) + x, при x = 5                  *");
            Console.WriteLine("* sin() в радианах.                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("************************ ИСХОДНЫЕ ДАННЫЕ: *********************************");
            int x = 5, i1 = 1, k1 = 1, i2 = 3, k2 = 14;
            Console.WriteLine($"* x = {x}, i: {i1}..{i2}, k: {k1}..{k2}                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("*************************** РЕЗУЛЬТАТ: ************************************");
            double y = ds.GetSumSumSeries(x, i1, k1, i2, k2);
            Console.WriteLine($"y = {y}");

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
