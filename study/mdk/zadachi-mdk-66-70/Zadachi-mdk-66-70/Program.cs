using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi_mdk_66_70
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double n, s, x, a, b;
                Console.WriteLine("\nВВЕДИТЕ НОМЕР УПРАЖНЕНИЯ (1-5):");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 5) { }
                else
                {
                    Console.WriteLine("Неизвестное упражнение");
                }
                switch (number)
                {

                    case 1:
                        {
                            n = 0;
                            s = 0;
                            while (s <= 249)
                            {
                                s = s + 24;
                                n = n + 10;
                            }
                            Console.WriteLine(n);
                        }
                        break;
                    case 2:
                        {
                            n = 15;
                            s = 0;
                            while (s <= 257)
                            {
                                s = s + 25;
                                n = n + 4;
                            }
                            Console.WriteLine(n);
                        }
                        break;
                    case 3:
                        {
                            n = 1;
                            s = 0;
                            while (s <= 365)
                            {
                                s = s + 37;
                                n = n + 2;
                            }
                            Console.WriteLine(n);
                        }
                        break;
                    case 4:
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                            a = 0; b = 0;
                            while (x > 0)
                            {
                                a = a + 1;
                                if (b < (x % 8))
                                {
                                    b = x % 8;
                                }
                                x = x / 8;
                            }
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                        }
                        break;
                    case 5:
                        {
                            n = 1;
                            s = 0;
                            while (s <= 365)
                            {
                                s = s + 36;
                                n = n * 2;
                            }
                            Console.WriteLine(n);
                        }
                        break;

                }
            }
        }
    }
}
