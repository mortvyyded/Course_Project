using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_Maltsev_Dmitry_group_881
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x, y;
                Console.WriteLine("\nВВЕДИТЕ НОМЕР УПРАЖНЕНИЯ (1-22):");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 22) {}
                else
                {
                    Console.WriteLine("Неизвестное упражнение");
                }
                switch (number)
                {
                    //Глава 1. Основы C#. Условные конструкции
                    case 1: //Упражнение 1
                        Console.WriteLine("\nУПРАЖНЕНИЕ 1");
                        Console.WriteLine("Введите первое число: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (x > y)
                        {
                            Console.WriteLine("Первое число больше второго");
                        }
                        else if (x < y)
                        {
                            Console.WriteLine("Первое число меньше второго");
                        }
                        else
                        {
                            Console.WriteLine("Оба числа равны");
                        }
                        break;
                    case 2: //Упражнение 2
                        Console.WriteLine("\nУПРАЖНЕНИЕ 2");
                        Console.WriteLine("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        if (x > 5 && x < 10)
                        {
                            Console.WriteLine("Число больше 5 и меньше 10");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                    case 3: //Упражнение 3
                        Console.WriteLine("\nУПРАЖНЕНИЕ 3");
                        Console.WriteLine("Введите число: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        if (x == 5 || x == 10)
                        {
                            Console.WriteLine("Число либо равно 5, либо равно 10");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                }
            }
        }
    }
}