using Tyuiu.ReneDS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task3.V15
{

    class Programm
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы сотавного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга                              *");
            Console.WriteLine("* и движутся в противоположные стороны.                                   *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1, v2, S, T;

            Console.WriteLine("Введите скорость первого автомобиля V1 (км/ч):");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость первого автомобиля V2 (км/ч):");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начальное расстояние S (км):");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время T (ч):");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями = " + ds.DistanceOverTime(v1, v2, S, T) + "км");

            Console.ReadLine();
        }
    }
}