//برنامه ای بنویسید که سه عدد را خوانده و با استفاده از ساختار متود ریشه ی دوم  ان معادله را  حساب کند
using System;
public class Exercise11
{
    public static void Main()
    {
        Console.WriteLine("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int d = b * b - 4 * a * c;
        double x1 = 0;
        double x2 = 0;
        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("root = {0} , {1}", x1, x2);
        }
        if (d == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("root = {0}", x1);
        }
        if (d < 0)
        {
            Console.WriteLine("no root");
        }
        Console.ReadKey();
    }
}