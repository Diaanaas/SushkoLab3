using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushkoLab3.CLasses
{
    public static class Calculator
    {
        private static Brush blue = new SolidBrush(Color.Blue);
        private static Brush red = new SolidBrush(Color.Red);
        private static Brush green = new SolidBrush(Color.Green);
        private static double a = 1;
        private static double b = 2;
        public static double t = 1;
        private static double h = 0.001;
        private static double endPoint = a + 3;
        private static double y = b;
        private static double maxY = 10;
        private static double minY = -10;
        public static void SolveRungeKutta2(double begin, double end)
        {
            double x = a;
            double y = b;

            Drawer.DrawPointMed(x, y, green);

            while (x < end && y < maxY)
            {
                double k1 = a * t * t + b * y;
                double k2 = a * (t + h) * (t + h) + b * (y + k1);

                y += h * (k1 + k2) / 2.0;
                x += h;

                Drawer.DrawPointMed(x, y, green);
            }

            x = a;
            y = b;

            Drawer.DrawPointMed(x, y, green);

            while (x > begin && y > minY)
            {
                double k1 = a * t * t + b * y;
                double k2 = a * (t + h) * (t + h) + b * (y + k1);

                y -= h * (k1 + k2) / 2.0;
                x -= h;

                Drawer.DrawPointMed(x, y, green);
            }
        }

        public static void SolveMilnaSimpsona(double begin, double end)
        {
            double x = a;
            double y = b;

            Drawer.DrawPointMed(x, y, blue);

            while (x < end && y < maxY)
            {
                double k1 = h * (a * t * t + b * y);
                double k2 = h * (a * (t + h / 2) * (t + h / 2) + b * (y + k1 / 2));
                double k3 = h * (a * (t + h / 2) * (t + h / 2) + b * (y + k2 / 2));
                double k4 = h * (a * (t + h) * (t + h) + b * (y + k3));

                y += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x += h;

                Drawer.DrawPointMed(x, y, blue);
            }

            x = a;
            y = b;

            Drawer.DrawPointMed(x, y, blue);

            while (x > begin && y > minY)
            {
                double k1 = h * (a * t * t + b * y);
                double k2 = h * (a * (t + h / 2) * (t + h / 2) + b * (y + k1 / 2));
                double k3 = h * (a * (t + h / 2) * (t + h / 2) + b * (y + k2 / 2));
                double k4 = h * (a * (t + h) * (t + h) + b * (y + k3));

                y -= (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x -= h;

                Drawer.DrawPointMed(x, y, blue);
            }
        }
    }
}
