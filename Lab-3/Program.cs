using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Запруднов Михаил ИУ5-32Б";
            Rectangle rect = new Rectangle(3, 2);
            Square sq = new Square(4);
            Circle cir = new Circle(6);


            ArrayList l1 = new ArrayList();
            l1.Add(cir);
            l1.Add(rect);
            l1.Add(sq);
            Console.WriteLine("ArrayList:");
            foreach (object i in l1) Console.Write(i.ToString() + " ");

            Console.Write("\nСписок:");
            List<Figure> l2 = new List<Figure>();
            l2.Add(cir);
            l2.Add(rect);
            l2.Add(sq);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            l2.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            Console.WriteLine("");

            Console.WriteLine("Стек:");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(sq);
            stack.Push(cir);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.WriteLine("\nМатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = sq;
            matrix[2, 2, 2] = cir;
            Console.WriteLine(matrix.ToString());
            Console.ReadKey();
        }
    }
}
