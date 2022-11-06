using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число. X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число. Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите код операции:\n      1 - сложение \n      2 - вычетание \n      3 - произведение \n      4 - частное");
            Console.Write("Ваш выбор: ");
            int i = Convert.ToInt32(Console.ReadLine());
            
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат - {0}", x+y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат - {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат - {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат - {0}", x / y);
                            break;
                        }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка делить на 0");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Нет такой операции");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат числа");
            }
            Console.ReadKey();

        }
    }
}
