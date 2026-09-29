using Tyuiu.ReneDS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task5.V6
{

    class Programm
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов  и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k от 1 до 365 — номер дня невисокосного года.          *");
            Console.WriteLine("* Определить номер дня недели для k-го дня, если 1 января - понедельник.  *");
            Console.WriteLine("* Дни недели пронумерованы от 1 (понедельник) до 7 (воскресенье).         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;

            Console.WriteLine("Введите номер дня года k (от 1 до 365):");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Номер дня недели = " + ds.Calculate(k));
            Console.WriteLine("1 — понедельник, 2 — вторник, 3 — среда,");
            Console.WriteLine("4 — четверг, 5 — пятница, 6 — суббота, 7 — воскресенье.");

            Console.ReadLine();
        }
    }
}
