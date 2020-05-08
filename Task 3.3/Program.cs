using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class Program
    {
        public static double f(double x)
        {
            double s;
            if (Math.Abs(x) < 2)
            {
                s = Math.Sqrt(5 * x * x + 5);
            }
            else if (Math.Abs(x) >= 2 && Math.Abs(x) < 10)
            {
                s = Math.Abs(x) / Math.Sqrt(5 * x * x + 5);
            }
            else
                s = 0;
            return s;
        }
        public static void f(double x, out double y)
        {
           
            if (Math.Abs(x) < 2)
            {
                y = Math.Sqrt(5 * x * x + 5);
            }
            else if (Math.Abs(x) >= 2 && Math.Abs(x) < 10)
            {
                y = Math.Abs(x) / Math.Sqrt(5 * x * x + 5);
            }
            else
                y = 0;
            
        }
        static void Main(string[] args)
        {
            double a, b, h;
            Console.WriteLine("Введите а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг h: ");
            h = Convert.ToDouble(Console.ReadLine());
            for (double i = a; i <= b; i = i + h)
            {
                Console.WriteLine(f(i));
            }
            Console.WriteLine();
            Console.WriteLine("Перегруженный метод");
            for (double i = a; i <= b; i = i + h)
            {
                double r;
                f(i, out r);
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
