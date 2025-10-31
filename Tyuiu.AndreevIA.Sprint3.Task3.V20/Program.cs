using Tyuiu.AndreevIA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.AndreevIA.Sprint3.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string text = "gfft ntf f opf";
            double result = ds.GetCharCount(text, 'f');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}