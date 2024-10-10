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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Лаврентьев Дмитрий Александрович | ИБКСб-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)            *");
            Console.WriteLine("* прошло к этому моменту.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество секунд (k) от начала суток: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            {
                int hours = ds.SecondsToHours(k);
                Console.WriteLine($"Полных часов, прошедших к моменту {k}-й секунды суток: {hours}");

            }
            Console.ReadLine();
        }
    }
}
