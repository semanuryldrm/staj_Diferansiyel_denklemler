using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferansiyel_denklemler
{
    //    class Euler_Yontemi
    //{
    //    static void Main()
    //    {
    //        double t = 0.0;
    //        double y = 1.0;

    //        double h = 0.1;

    //        Console.WriteLine("Adım\t t\t y (yaklaşık)");

    //        for (int i = 0; i <= 10; i++)
    //        {
    //            Console.WriteLine($"{i}\t {t}\t {y}");

    //            double turev = t + y;

    //            y = y + h * turev;
    //            t = t + h;
    //        }
    //    }
    //}

    //class RK4_Yontemi
    //{
    //    static void Main()
    //    {
    //        double t = 0.0;
    //        double y = 1.0;
    //        double h = 0.1;

    //        Console.WriteLine("Adım\t t\t y (yaklaşık)");

    //        for (int i = 0; i <= 10; i++)
    //        {
    //            Console.WriteLine($"{i}\t {t}\t {y}");

    //            double k1 = h * (t + y);
    //            double k2 = h * ((t + h / 2) + (y + k1 / 2));
    //            double k3 = h * ((t + h / 2) + (y + k2 / 2));
    //            double k4 = h * ((t + h) + (y + k3));

    //            y = y + (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);

    //            t = t + h;
    //        }
    //    }
    //}

    class Adams_Bashforth_Yontemi
    {
        static void Main()
        {
            double h = 0.1;
            int adim = 10;
            double[] t = new double[adim + 1];
            double[] y = new double[adim + 1];
            double[] f = new double[adim + 1];

            t[0] = 0.0;
            y[0] = 1.0;
            f[0] = t[0] + y[0]; 

            Console.WriteLine("Adım\t t\t y (yaklaşık)");

            Console.WriteLine($"0\t {t[0]}\t {y[0]}");

            double k1 = h * (t[0] + y[0]);
            double k2 = h * (t[0] + h / 2 + (y[0] + k1 / 2));
            double k3 = h * (t[0] + h / 2 + (y[0] + k2 / 2));
            double k4 = h * (t[0] + h + (y[0] + k3));

            y[1] = y[0] + (k1 + 2 * k2 + 2 * k3 + k4) / 6.0;
            t[1] = t[0] + h;
            f[1] = t[1] + y[1];

            Console.WriteLine($"1\t {t[1]}\t {y[1]}");

            for (int i = 1; i < adim; i++)
            {
                t[i + 1] = t[i] + h;

                y[i + 1] = y[i] + h / 2.0 * (3 * f[i] - f[i - 1]);

                f[i + 1] = t[i + 1] + y[i + 1]; 

                Console.WriteLine($"{i + 1}\t {t[i + 1]}\t {y[i + 1]}");
            }
        }
    }

}
