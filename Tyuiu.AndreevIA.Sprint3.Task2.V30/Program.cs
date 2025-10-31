using Tyuiu.AndreevIA.Sprint3.Task2.V30.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 0.25;
            int startValue = 1, endValue = 11;
            Console.Title = "Спринт #3 | Выполнил Андреев И. А. | РППб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл d0-while                              *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 0,25, 1 <= i <= 11                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произвездение равно " + ds.GetMultiplySeries(x, startValue, endValue));
            Console.ReadLine();
        }
    }
}