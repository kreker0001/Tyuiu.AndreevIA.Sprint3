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

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |    f(x)  |");
        Console.WriteLine("+----------+----------+");

        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("|{0,5:d}     |   {1,5:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");

        

        Console.ReadKey();
    }
}