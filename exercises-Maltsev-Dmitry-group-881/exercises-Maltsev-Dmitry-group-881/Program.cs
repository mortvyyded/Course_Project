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
            int number = 1;

            switch (number)
            {
                //Глава 1. Основы C#. Условные конструкции
                case 1: //Упражнение 1
                    Console.WriteLine("УПРАЖНЕНИЕ 1");
                    Console.WriteLine("Введите первое число: ");
                    int ex1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int ex1_1 = Convert.ToInt32(Console.ReadLine());

                    if (ex1 > ex1_1)
                    {
                        Console.WriteLine("Первое число больше второго");
                    }
                    else if (ex1 < ex1_1)
                    {
                        Console.WriteLine("Первое число меньше второго");
                    }
                    else
                    {
                        Console.WriteLine("Оба числа равны");
                    }
                    goto case 2;
                case 2: //Упражнение 2
                    Console.WriteLine("УПРАЖНЕНИЕ 2");
                    Console.WriteLine("Введите число: ");
                    int ex2 = Convert.ToInt32(Console.ReadLine());

                    if (ex2 > 5 && ex2 < 10)
                    {
                        Console.WriteLine("Число больше 5 и меньше 10");
                    }
                    else
                    {
                        Console.WriteLine("Неизвестное число");
                    }
                    goto case 3;
                case 3: //Упражнение 3
                    Console.WriteLine("УПРАЖНЕНИЕ 3");
                    Console.WriteLine("Введите число: ");
                    int ex3 = Convert.ToInt32(Console.ReadLine());

                    if (ex3 == 5 || ex3 == 10)
                    {
                        Console.WriteLine("Число либо равно 5, либо равно 10");
                    }
                    else
                    {
                        Console.WriteLine("Неизвестное число");
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}