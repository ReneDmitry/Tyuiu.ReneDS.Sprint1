using Tyuiu.ReneDS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task6.V16
{
    class Programm
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст.                                              *");
            Console.WriteLine("* Проверить, что в строке есть восклицательный знак (!)                    *");
            Console.WriteLine("* и вопросительный знак (?).                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value;

            Console.WriteLine("Введите текст:");
            value = Console.ReadLine() ?? "";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("В строке есть оба символа (! и ?): "
                + ds.CheckSpecSymbols(value));

            Console.ReadLine();
        }
    }
}
