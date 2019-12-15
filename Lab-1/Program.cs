using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void input(ref double a, ref double b, ref double c)
        {
            try
            {
                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены некорректные данные");
                Console.ResetColor();
                input(ref a, ref b, ref c);
            }
        }
        
            static void Main(string[] args)
        {
            Console.Title = "Запруднов Михаил ИУ5-32Б";
            double a=0, b=0, c=0, D, t1, t2,x1,x2,x3,x4;
            bool f1=false,f2=false;
            input(ref a, ref b, ref c);

            if (args.Length == 3)
            {
                try
                {
                    a = Convert.ToDouble(args[0]);
                    b = Convert.ToDouble(args[1]);
                    c = Convert.ToDouble(args[2]);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены некорректные данные");
                    return;
                }
            }
            if ((a != 0) && (b != 0))
            {
                D = b * b - 4 * a * c;
                t1 = (-b + Math.Sqrt(D)) / (2 * a);
                t2 = (-b - Math.Sqrt(D)) / (2 * a);
                if (t1 >= 0)
                {
                    x1 = Math.Sqrt(t1);
                    x2 = -Math.Sqrt(t1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                    f1 = true;

                }
                if (t2 >= 0)
                {
                    x3 = Math.Sqrt(t2);
                    x4 = -Math.Sqrt(t2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x3= {0}\nx4= {1}", x3, x4);
                    f2 = true;
                }
            }
            else
            {
                if ((a == 0) && (b == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Уравнение не составлено\n");
                    f1 = true;
                }
                else
                {
                    if (a == 0)
                    {
                        t1 = -c / b;
                        if (t1 > 0)
                        {
                            x1 = Math.Sqrt(t1);
                            x2 = -Math.Sqrt(t1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                            f1 = true;
                        }
                        if (t1 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("x1= {0}\nx2= {1}", 0, 0);
                            f1 = true;
                        }
                    }
                    if (b == 0)
                    {
                        if ((-c / a) > 0)
                        {
                            t1 = Math.Sqrt(-c / a);
                            x1 = Math.Sqrt(t1);
                            x2 = -Math.Sqrt(t1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                            f1 = true;
                        }
                        if ((-c / a) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("x1= {0}\nx2= {1}\nx3= {2}\nx4= {3}", 0, 0, 0, 0);
                            f1 = true;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            if (!f1 && !f2) Console.WriteLine("Действительных корней нет\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
