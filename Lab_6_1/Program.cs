using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1
{
    delegate int MultiplyOrDevide(int p1, int p2);


    class Program
    {

        static int Multiply(int p1, int p2) { return p1 * p2; }
        static int Devide(int p1, int p2) { return p1 / p2; }


        static void MultiplyOrDevideMethodFunc(string str, int i1, int i2, Func<int, int, int> MultiplyOrDevideParam)
        {
            int Result = MultiplyOrDevideParam(i1, i2);
            Console.WriteLine(str + Result.ToString());



        }

        static void MultiplyOrDevideMethod(string str, int i1, int i2, MultiplyOrDevide MultiplyOrDevideParam)
        {
            int Result = MultiplyOrDevideParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        static void Main(string[] args)
        {
            int i1 = 9;
            int i2 = 3;

            MultiplyOrDevideMethod("Умножить: ", i1, i2, Multiply);
            MultiplyOrDevideMethod("Делить: ", i1, i2, Devide);

            MultiplyOrDevide pm1 = new MultiplyOrDevide(Multiply);
            MultiplyOrDevideMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1);


            MultiplyOrDevide pm2 = Multiply;
            MultiplyOrDevideMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);


            MultiplyOrDevide pm3 = delegate (int param1, int param2)
            {
                return param1 * param2;
            };
            MultiplyOrDevideMethod("Создание экземпляра делегата на основе анонимного метода: ", i1, i2, pm2);

            MultiplyOrDevideMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                (int x, int y) =>
                {
                    int z = x * y;
                    return z;
                }
                );

            MultiplyOrDevideMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                (x, y) =>
                {
                    return x * y;
                }
                );

            MultiplyOrDevideMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x * y);


            Console.WriteLine("\n\nИспользование обощенного делегата Func<>");

            MultiplyOrDevideMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiply);

            string OuterString = "ВНЕШНЯЯ ПЕРЕМЕННАЯ";

            MultiplyOrDevideMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                (int x, int y) =>
                {
                    Console.WriteLine("Эта переменная объявлена вне лямбда-выражения: " + OuterString);
                    int z = x * y;
                    return z;
                }
                );

            MultiplyOrDevideMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                (x, y) =>
                {
                    return x * y;
                }
                );

            MultiplyOrDevideMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x * y);



            Console.WriteLine("Пример группового делегата");
            Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} * {1} = {2}", x, y, x * y); };
            Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} / {1} = {2}", x, y, x / y); };
            Action<int, int> group = a1 + a2;
            group(20, 4);

            Action<int, int> group2 = a1;
            Console.WriteLine("Добавление вызова метода к групповому делегату");
            group2 += a2;
            group2(15, 5);
            Console.WriteLine("Удаление вызова метода из группового делегата");
            group2 -= a1;
            group2(36, 6);

            Console.ReadLine();
        }
    }
}
