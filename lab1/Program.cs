using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main(string[] args)
    {
        Line lin1 = new Line();
        
        Console.WriteLine("Vvedite 'X1' koordinati pervoi pryamoi : ");
        lin1.x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'X2' koordinati pervoi pryamoi : ");
        lin1.x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'Y1' koordinati pervoi pryamoi : ");
        lin1.y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'Y2' koordinati pervoi pryamoi : ");
        lin1.y2 = Convert.ToDouble(Console.ReadLine());

        Line lin2 = new Line();
        Console.WriteLine("Vvedite 'X1' koordinati pervoi pryamoi : ");
        lin2.x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'X2' koordinati pervoi pryamoi : ");
        lin2.x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'Y1' koordinati pervoi pryamoi : ");
        lin2.y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedite 'Y2' koordinati pervoi pryamoi : ");
        lin2.y2 = Convert.ToDouble(Console.ReadLine());

        Calc a = new Calc();
        Point g;
        g = a.res(lin1, lin2);
        if (g.r == false)
        {
            Console.WriteLine("Tochki net");
        Console.ReadKey();
        }
        else
        {
            Console.Write("x=");
            Console.WriteLine(g.x);
            Console.Write("y=");
            Console.WriteLine(g.y);
            Console.ReadKey();
        }

    }
    }
