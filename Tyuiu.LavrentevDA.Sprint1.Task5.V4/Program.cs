using Tyuiu.LavrentevDA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Лаврентьев Д.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыкы работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Лаврентьев Дмитрий Александрович | ИБКСб-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k, time;

            Console.WriteLine("Введите секунды суток:");
            k = Convert.ToInt32(Console.ReadLine());
           // h = Convert.ToInt32(Console.ReadLine());
             //h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(DataService.SecondsToHours(int time));
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           // Console.WriteLine("1 / ( x + sqrt Y ) = " + ds.Calculate(x, sqrtY));
            Console.WriteLine($"Прошло полных часов: {time}");
            Console.ReadLine();
        }
    }
}
