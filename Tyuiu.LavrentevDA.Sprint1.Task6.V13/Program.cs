using Tyuiu.LavrentevDA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.LavrentevDA.Sprint1.Task6.V13
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Лаврентьев Дмитрий Александрович | ИБКСб-24-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст:");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
            bool sanitizedInput = ds.CheckWordsAlphabet(string.Empty);
           
            if (sanitizedInput)
            {
                Console.WriteLine("Буквы в строке упорядочены по алфавиту.");
            }
            else
            {
                Console.WriteLine("Буквы в строке не упорядочены по алфавиту.");
            }
        }
    }
}
