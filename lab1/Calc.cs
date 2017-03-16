using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Calc
    {
    public bool r;
    public Point res(Line lin1, Line lin2)
    {
        r = false;
        double A1, B1, C1, A2, B2, C2;
        A1 = lin1.y1 - lin1.y2;
        B1 = lin1.x2 - lin1.x1;
        C1 = lin1.x1 * lin1.y2 - lin1.x2 * lin1.y1;
        A2 = lin2.y1 - lin2.y2;
        B2 = lin2.x2 - lin2.x1;
        C2 = lin2.x1 * lin2.y2 - lin2.x2 * lin2.y1;

        double x, y;
        y = (-A2 * C1 + C2 * A1) / (A2 * B1 - A1 * B2);
        x = (-C1 - B1 * y) / A1;

        if (A1 * B2 - A2 * B1 == 0)
        {
            r = false;
            return new Point(0, 0, false);
        }
        else
        {
            r = true;
            return new Point(x, y, r);
        }
         


    }
    }
