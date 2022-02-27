using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x;
            decimal y;
            int c;

            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число. Х=");
                x = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                y = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Выберите код операции:\n 1 - сложение\n 2 - вычитание\n 3 - произведение\n 4 - деление\n Ваш выбор: ");
                c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Результат = {0}", x + y);
                        break;
                    case 2:
                        Console.WriteLine("Результат = {0}", x - y);
                        break;
                    case 3:
                        Console.WriteLine("Результат = {0}", x * y);
                        break;
                    case 4:
                        Console.WriteLine("Результат = {0:f2}", x / y);

                        break;
                    default:
                        Console.WriteLine("Неверный код операции");
                        break;
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("Неверный формат входной строки");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0!");
            }

            Console.ReadKey();
        }
    }
}
