using Tyuiu.PiskulinIY.Sprint3.Task6.V11.Lib;
namespace Tyuiu.PiskulinIY.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 19;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("кол-во делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();

        }
    }
}
